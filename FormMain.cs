using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.Numerics;
using System.Net.Sockets;
//
using NativeWifi;
using System.Runtime.InteropServices;

using System.Data.SqlClient;
using System.IO;



//

namespace ViberationScope
{
    public partial class ViberationScope : Form
    {
        UInt32 numPointPerLine = 1024;
        double[,] chartData;
        const int minChartRange = 8;
        int cnt1,cnt2;
        double computedFreq = 0;
        double [] fft_mag;
        List<double> marks = new List<double>();
        int numRun=1;
        const double b1=0.995;
        double b2=1-b1;
        Complex x1, x2;
        const int frameLen = 3;//表示framelen是一个常量
        UInt32 index = 0;
        Thread thrdDataReceived=null;
        Boolean isRunning = false;
        BlockingCircularBuffer<byte> buf1;
        sampleData originalData = new COMData();//抽样数据
        Post_Wire selectedPostWire = new Post_Wire();

        object originalDataDevice;
        System.IO.FileStream fsRawData;
        Queue<double> sampleQ = new Queue<double>();//
        ShiftBuffer<double> spikes;
        //
        [DllImport("wininet.dll")]
        public static extern bool InternetGetConnectedState(out long lpdwFlags, long dwReserved);
        //
        public ViberationScope()
        {
            InitializeComponent();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            System.IO.Ports.SerialPort sp = sender as System.IO.Ports.SerialPort;

           // System.IO.FileStream fs = System.IO.File.OpenRead(ofd.FileName);
            lock (sp)
            {
                while (sp.BytesToRead > 0)//所记录接受数据值大于0
                {
                    byte b = (byte)sp.ReadByte();//读取缓冲数据

                    buf1.Put(b);
                    fsRawData.WriteByte(b);//用于只写
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRunning = false;
            for (int i = 0; i < frameLen; i++)
            {
                buf1.Put(0x0);
            }
            toolStripButton_Stop_Click(sender, e);
            SystemSetup.getInstance().save();
        }
        //kai
        System.Windows.Forms.Timer timerTmp = new System.Windows.Forms.Timer();
        //jie
        private void Form1_Load(object sender, EventArgs e)
        {
            //kai
            timerTmp.Interval = 1000;//一秒
            timerTmp.Tick += new EventHandler(timerTmp_Tick);



            timerTmp.Enabled = true;
            //jie
            Multiple_ComboBox.SelectedIndex = Multiple_ComboBox.Items.Count / 2;
            SystemSetup.getInstance().init();
            try
            {
                numPointPerLine = SystemSetup.getInstance().dev_Setup.NumFFT;
                buf1 = new BlockingCircularBuffer<byte>(numPointPerLine * 4);
                chartData = new double[chart_Wave.Series.Count, numPointPerLine];
                serialPort1.PortName = SystemSetup.getInstance().dev_Setup.DevPortName;//串口名称
                serialPort1.BaudRate = SystemSetup.getInstance().dev_Setup.BaudRate;//波特率
                originalDataDevice = serialPort1;
                cnt2 = 100;
                spikes = new ShiftBuffer<double>(numPointPerLine);
                fft_mag = new double[numPointPerLine];

                thrdDataReceived = new Thread(new ThreadStart(DataReceived));
                thrdDataReceived.Start();

                WifiData wd = new WifiData();
                wd.buf1 = buf1;
                originalData = wd;
                originalData.onEvent += new TimerCallback(onStopMeasure);
                //toolStripButton_Start_Click(this, null);

            }
            catch (Exception ex) { }
            timer1.Enabled = true;
        }

        //kai
        Wlan.WlanAvailableNetwork[] wlanAvailableNetworks;
        private void refresh()
        {
            Wifi_list.Items.Clear();
            WlanClient wlanClientTmp = new WlanClient();
            if (wlanClientTmp.Interfaces.Length != 0)
            {
                WlanClient.WlanInterface wlanInterfaceTmp = wlanClientTmp.Interfaces[0];
                Wlan.WlanAvailableNetwork[] wlanAvailableNetworksTmp
                    = wlanInterfaceTmp.GetAvailableNetworkList(Wlan.WlanGetAvailableNetworkFlags.IncludeAllAdhocProfiles);
                wlanAvailableNetworks = wlanAvailableNetworksTmp;
                int i = 0;
                foreach (Wlan.WlanAvailableNetwork wlanAvailableNetworkTmp in wlanAvailableNetworksTmp)
                {
                    String ssid = GetStringForSSID(wlanAvailableNetworkTmp.dot11Ssid);
                    if (!ssid.StartsWith("ZSKJ")) continue;
                    if (wlanAvailableNetworkTmp.profileName.Length==0) continue;
                    wlanAvailableNetworks[i++] = wlanAvailableNetworkTmp;
                }
                Array.Resize(ref wlanAvailableNetworks, i);
                foreach (Wlan.WlanAvailableNetwork wlanAvailableNetworkTmp in wlanAvailableNetworks)
                {
                    ListViewItem lviTmp = new ListViewItem(
                        new string[]{
                        GetStringForSSID(wlanAvailableNetworkTmp.dot11Ssid),
                        wlanAvailableNetworkTmp.wlanSignalQuality.ToString() + "%",
                        wlanAvailableNetworkTmp.networkConnectable.ToString(),
                        Convert.ToInt64(wlanAvailableNetworkTmp.flags).ToString()
                        }
                    );
                    Wifi_list.Items.Add(lviTmp);
                }
            }
        }
        private void timerTmp_Tick(object sender, EventArgs e)
        {
            try
            {
                timerTmp.Interval = 60000;
                refresh();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    
        private void wlanInterfaceTmp_WlanConnectionNotification(Wlan.WlanNotificationData notifyData, Wlan.WlanConnectionNotificationData connNotifyData)
        {
            if (connNotifyData.profileName != "")
            {
                Vibrator_label.Text = "已连接至：" + connNotifyData.profileName;
            }
        }



        private void setupCOM()
        {
        }

        private void onStopMeasure(object o)
        {
            if ((String)o == "Stopped")
            {
                fsRawData.Close();
                timer1.Enabled = false;
            }
        }

        void DataReceived()
        {
            isRunning = true;
            byte[] buf = new byte[frameLen] { 0, 0, 0 };
            while (isRunning)
            {
                if (buf[0] == 0xA5)
                {
                    index = (index + 1) % numPointPerLine;
                    chartData[0,index] = BitConverter.ToInt16(buf, 1);
                    lock (sampleQ)
                    {
                        sampleQ.Enqueue(chartData[0, index]);//添加数据在sampleQ
                    }
                    for (int i = 0; i < frameLen; i++)
                    {
                        buf[i] = buf1.Get();
                    }
                }
                else
                {
                    for (int i = 0; i < frameLen-1; i++)
                    {
                        buf[i] = buf[i + 1];
                    }
                    buf[frameLen-1] = buf1.Get();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chart_Wave.Series[0].Points.Clear();//刷新控件内数据

            chart_Wave.Series[1].Points.Clear();
            chart_Wave.Series[2].Points.Clear();
            chart_Wave.Series[3].Points.Clear();
            foreach (float mark in marks)
            {
                Font drawFont = new Font("Arial", 16);
                SolidBrush drawBrush = new SolidBrush(Color.Red);

                // Create point for upper-left corner of drawing.
                PointF drawPoint = new PointF(mark, 0);
                Graphics g = chart_Wave.CreateGraphics();
                g.DrawString("*", drawFont, drawBrush, drawPoint);

            }
            Complex[] inArr = new Complex[numPointPerLine];
            inArr[0] = chartData[0,0];
            for (int i = 1; i < inArr.Length; i++)
            {
                inArr[i] = chartData[0,i];
            }
            System.Numerics.Complex[] newfft = DSP.FFT(inArr);
            for (UInt32 i = index; i < numPointPerLine; i++)
            {
                chart_Wave.Series[0].Points.Add(chartData[0,i] + 200);
            }
            for (int i = 0; i < index; i++)
            {
                chart_Wave.Series[0].Points.Add(chartData[0,i]+200);
            }
            for (int i = 0; i < numPointPerLine; i++)
            {
                fft_mag[i] = newfft[i].Magnitude;
            }
            for (int i = 0; i < fft_mag.Length; i++)
            {
                chart_Wave.Series[1].Points.Add(fft_mag[i] / 4 - 100);
            }
            lock (sampleQ)
            {
                while (sampleQ.Count > 0)
                {
                    double s = sampleQ.Dequeue();
                }
            }
            for (uint i = 0; i < numPointPerLine; i++)
            {
                chart_Wave.Series[2].Points.Add(spikes.ElementAt(i) / 4 - 20);
            }
            float  F, f1, f2, diff;
            if (float.TryParse(Frequency_box1.Text, out f1) && float.TryParse(Frequency_box2.Text, out f2) && float.TryParse(Wavedifference_box.Text, out diff) && diff != 0)
            {                //f0= ((f2 - f1) / diff.ToString();
                F = calculat((f2 - f1) / diff);
                Force_label.Text = F.ToString();
            }  

                   
        }

        private float calculat(float v)
        {
            double  F = 0;
            double g = 9.80665;
            double ρ, D, l, θ, H, E = 181000;

            l = selectedPostWire.thePost.H / Math.Sin(selectedPostWire.thePost.theta*Math.PI/180);
            //导入拉线表数据
            D = selectedPostWire.theWire.D;
            ρ = selectedPostWire.theWire.rho;
            if (selectedPostWire.thePost.type.Equals("LV型"))
            {
                double h0 = 4 * ρ * v * v * l * l;
                double N,h,h1,L;
                do
                {
                   
                     h1 = Math.Pow(ρ * l * l * ((4 * v * v * h0 * h0) - 7.569 * ρ * E * Math.PI * D * D / 4),1.0/3);
                     N =Math.Abs( 100 * (h1 - h0) / h0);
                     h0 = h1;
                     
                }
                while (N > 0.01);
                 h = h1;
                 L = l*(1+(1/8)*(ρ*g*l/h)*(ρ*g*l/h));
                double X = (Math.Pow((ρ * g * l * l / h), 2)) * ((E * l) / (h * L)) * Math.PI * D * D / 4;
                System.Console.WriteLine("ρ:{0} l:{1} h:{2} X:{3}", ρ, l, h, X);
                if (X<=0.17)
                {
                    F = 4 * ρ * l * l * v * v;
                }
                else if (X>0.17&&X<4*Math.PI*Math.PI)
                {
                    double F0 =4 * ρ * l * l * v * v;
                    double F1;
                    double Y;
                    do
                    {
                        F1 = Math.Pow(ρ * l * l * (4 * v * v * F0 * F0 - 7.569 * ρ * E * Math.PI * D * D / 4), 1.0 / 3);
                        Y = 100 * (F1 - F0) / F0;
                        F0 = F1;
                    }
                    while (Y > 0.01);
                    F = F1;
                }
                else if(X>=4*Math.PI*Math.PI) 
                {
                    F=ρ*l*l * v * v;
                }

            }
            else
            {
                F = ρ*l*l*v*v-(4*Math.PI* Math.PI / (l*l))*E*(Math.PI*D*D*D*D/32);

            }
            return (float)F;
        }

        private void toolStripButton_Start_Click(object sender, EventArgs e)
        {
            UInt32 delay;//32位无符号整型
            UInt32 threshold;
            uint.TryParse(toolStripTextBox1.Text, out delay);
            uint.TryParse(toolStripTextBox2.Text, out threshold);
            fsRawData = System.IO.File.Create(SystemSetup.getInstance().dev_Setup.DataPath + "\\temp");
            originalData.Start(originalDataDevice);
            Text = originalData.Text;
            timer1.Enabled = true;
            toolStripButton_Start.Enabled = false;
            toolStripButton_Stop.Enabled = true;
        }

        private void toolStripButton_Stop_Click(object sender, EventArgs e)
        {
            originalData.Stop();
            if (fsRawData != null)
                fsRawData.Close();
            toolStripButton_Start.Enabled = true;
            toolStripButton_Stop.Enabled = false;
        }

        private void toolStripButton_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (DialogResult.OK == ofd.ShowDialog())
            {
                System.IO.FileStream fs = System.IO.File.OpenRead(ofd.FileName);
               // System.IO.FileStream fsRawData=System.IO.File.OpenRead(ofd.FileName);
                byte[] buf = new byte[frameLen] { 0, 0, 0 };
                while (fs.Position < fs.Length)
                //while (fsRawData.Position < fsRawData.Length)
                {
                    if (buf[0] == 0xA5)
                    {
                        index = (index + 1) % numPointPerLine;
                        chartData[0,index] = BitConverter.ToInt16(buf, 1);
                        for (int i = 0; i < frameLen; i++)
                        {
                            buf[i] = (byte)fsRawData.ReadByte();
                        
                        }
                    }
                    else
                    {
                        for (int i = 0; i < frameLen - 1; i++)
                        {
                            buf[i] = buf[i + 1];
                        }
                        buf[frameLen - 1] = (byte)fsRawData.ReadByte();
                    }
                }
            }
        }

        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (DialogResult.OK == sfd.ShowDialog())
            {
                System.IO.FileStream fs_in = System.IO.File.OpenRead(SystemSetup.getInstance().dev_Setup.DataPath + "\\temp");
                System.IO.FileStream fs_out = System.IO.File.OpenWrite(sfd.FileName + ".txt");
                const int frameLen = 3;
                byte[] buf = new byte[frameLen] { 0, 0, 0 };
                string data;
                while (fs_in.Position < fs_in.Length)
                {
                    if (buf[0] == 0xA5)
                    {
                        data = BitConverter.ToInt16(buf, 1).ToString();
                        byte[] databuf = System.Text.ASCIIEncoding.ASCII.GetBytes(data);
                        fs_out.Write(databuf, 0, databuf.Length);
                        fs_out.WriteByte(0x2c);
                        for (int i = 0; i < frameLen; i++)
                        {
                            buf[i] = (byte)fs_in.ReadByte();
                        }
                    }
                    else
                    {
                        for (int i = 0; i < frameLen - 1; i++)
                        {
                            buf[i] = buf[i + 1];
                        }
                        buf[frameLen - 1] = (byte)fs_in.ReadByte();
                    }
                }
                fs_out.Close();
                fs_in.Close();

                System.IO.FileInfo fi = new System.IO.FileInfo(SystemSetup.getInstance().dev_Setup.DataPath+"\\temp");
                fi.CopyTo(sfd.FileName,true);
                //buf1.saveHistory(sfd.FileName);
            }
        }

        static string GetStringForSSID(Wlan.Dot11Ssid ssid)
        {
            return Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
        }

        
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //kai    





            try
            {
                WlanClient wlanClientTmp = new WlanClient();

                if (wlanClientTmp.Interfaces.Length != 0)
                {
                    WlanClient.WlanInterface wlanInterfaceTmp = wlanClientTmp.Interfaces[0];
                    wlanInterfaceTmp.WlanConnectionNotification += new WlanClient.WlanInterface.WlanConnectionNotificationEventHandler(wlanInterfaceTmp_WlanConnectionNotification);

                    int index = Wifi_list.Items.IndexOf(Wifi_list.SelectedItems[0]);
                    wlanInterfaceTmp.Connect(Wlan.WlanConnectionMode.Profile, wlanAvailableNetworks[index].dot11BssType, wlanAvailableNetworks[index].profileName);

                    Vibrator_label.Text = "正在连接网络：" + wlanAvailableNetworks[index].profileName;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            //jie

        }


        private void chart_Wave_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            System.Console.WriteLine(chart_Wave.Width);
            System.Console.WriteLine(me.X);
            float f = me.X * 200 / chart_Wave.Width;
            if (marks.Count == 0)
            {
                marks.Add(me.X);
                Frequency_box1.Text = f.ToString();
            }
            else if (marks.Count == 1)
            {
                marks.Add(me.X);
                Frequency_box2.Text = f.ToString();
            }
            else
            {
                marks.Clear();
            }
        }

        private void chart_Wave_CursorPositionChanged(object sender, System.Windows.Forms.DataVisualization.Charting.CursorEventArgs e)
        {
            System.Console.WriteLine(e.NewPosition);
        }

       private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormConfig fcf = new FormConfig();
            if (fcf.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
        
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Data_Choice frmParams = new Data_Choice();
            frmParams.thePostWire = selectedPostWire;
            if (frmParams.ShowDialog() == DialogResult.OK)
            {
            }
        }

    

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart_Wave.ChartAreas[0].AxisY.Minimum = -minChartRange * Math.Pow(2, Multiple_ComboBox.SelectedIndex);
            chart_Wave.ChartAreas[0].AxisY.Maximum = minChartRange * Math.Pow(2, Multiple_ComboBox.SelectedIndex);
        }

        private void toolStripButton_Config_Click(object sender, EventArgs e)
        {


            try
            {
                refresh();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

           
        }

        internal class firstDataSet2TableAdapters
        {
            internal class Table_PostTableAdapter
            {
                internal bool ClearBeforeFill;

                public Table_PostTableAdapter()
                {
                }

                internal void Fill(object table_Post)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
    class sampleData
    {
        public System.Threading.TimerCallback onEvent;
        public virtual String Text
        {
            get { return ""; }
        }
        public virtual void Start(object src)
        {
        }
        public virtual void Stop()
        {
        }
    }
    class COMData : sampleData//抽样数据
    {
        System.IO.Ports.SerialPort thePort; //接口
        public override void Start(object src) //SRC
        {
            try
            {
                thePort = src as System.IO.Ports.SerialPort;//接口即Src
                thePort.Open();
            }
            catch (Exception ex) { }
        }
        public override void Stop()
        {
            lock (thePort)//爆错
            {
                thePort.Close();
            }
            onEvent("Stopped");
        }
        public override String Text
        {
            get { return thePort.PortName; }
        }
    }
    class FileData : sampleData
    {
        bool isRunning;
        public CircularBuffer<byte> buf1=null;
        public override void Start(object src)
        {
            _Text = src.ToString();
            System.Threading.Thread thrd = new Thread(new System.Threading.ParameterizedThreadStart(loadData));
            thrd.Start(src as string);
        }
        public override void Stop()
        {
            isRunning=false;
        }
        String _Text;
        public override String Text
        {
            get { return _Text; }
        }
        void loadData(object o)

        {


            
            string filename = o as string;
            System.IO.FileStream fs = System.IO.File.OpenRead(filename);
            byte b = 0;
            isRunning = true;
            while (isRunning==true&&fs.Position < fs.Length)
            {
                for (int i = 0; i < 3; i++)
                {
                    b = (byte)fs.ReadByte();
                    buf1.Put(b);
                }
                System.Threading.Thread.Sleep(1);
            }
            onEvent("Stopped");
        }

    }
    class WifiData : sampleData
    {
        bool isRunning;
        public CircularBuffer<byte> buf1 = null;
        System.Net.Sockets.UdpClient s;
        public override void Start(object src)
        {
            _Text = src.ToString();
            System.Threading.Thread thrd = new Thread(new System.Threading.ParameterizedThreadStart(loadData));
            System.Console.WriteLine("begin");

            s = new System.Net.Sockets.UdpClient(60000);
            thrd.Start(src as string);//声明src是字符串类型
        }
        public override void Stop()
        {
            isRunning = false;
            if (s == null) return;
            s.Close();
        }
        String _Text;
        public override String Text
        {
            get { return _Text; }
        }
        void loadData(object o)
        {
            string filename = o as string;
            System.Console.WriteLine("begin");

            System.Net.IPAddress _addr = new System.Net.IPAddress(new byte[] { 192, 168, 2, 1 });
            System.Net.IPEndPoint _ep = new System.Net.IPEndPoint(_addr, 8000);
            s.Send(new byte[] { 0xaa }, 1, _ep);
            isRunning = true;

            //读取exsel表
           


             
        




            try
            {
                while (isRunning == true)
                {
                   




                    byte[] recvBuf = s.Receive(ref _ep);
                    int pos = 0;
                    byte[] package = new byte[100];
                    while (pos < recvBuf.Length)
                    {
                        Array.Copy(recvBuf, pos, package, 0, 100);
                        for (int i = 2; i < package.Length - 2; i += 6)
                        {
                            buf1.Put(0xA5);
                            buf1.Put(package[i]);
                            buf1.Put(package[i + 1]);
                        }
                        pos += 100;

                    }
                }
            }
            catch (Exception ex)
            {

            }
            onEvent("Stopped");
        }

       

    }


}
