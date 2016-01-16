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

namespace ViberationScope
{
    public partial class Form1 : Form
    {
        UInt32 numPointPerLine = 1024;
        double[,] chartData;
        const int minChartRange = 8;
        int cnt1,cnt2;
        double computedFreq = 0;
        double [] fft_mag;
        double a1;
        int numRun=1;
        const double b1=0.995;
        double b2=1-b1;
        Complex x1, x2;
        const int frameLen = 3;
        UInt32 index = 0;
        Thread thrdDataReceived=null;
        Boolean isRunning = false;
        BlockingCircularBuffer<byte> buf1;
        sampleData originalData = new COMData();
        object originalDataDevice;
        System.IO.FileStream fsRawData;
        Queue<double> sampleQ = new Queue<double>();
        ShiftBuffer<double> spikes;
        public Form1()
        {
            InitializeComponent();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            System.IO.Ports.SerialPort sp = sender as System.IO.Ports.SerialPort;
            lock (sp)
            {
                while (sp.BytesToRead > 0)
                {
                    byte b = (byte)sp.ReadByte();
                    buf1.Put(b);
                    fsRawData.WriteByte(b);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedIndex = toolStripComboBox1.Items.Count / 2;
            SystemSetup.getInstance().init();
            try
            {
                numPointPerLine = SystemSetup.getInstance().dev_Setup.NumFFT;
                buf1 = new BlockingCircularBuffer<byte>(numPointPerLine * 4);
                chartData = new double[chart1.Series.Count, numPointPerLine];
                serialPort1.PortName = SystemSetup.getInstance().dev_Setup.DevPortName;
                serialPort1.BaudRate = SystemSetup.getInstance().dev_Setup.BaudRate;
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
                        sampleQ.Enqueue(chartData[0, index]);
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
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            Complex[] inArr = new Complex[numPointPerLine];
            inArr[0] = chartData[0,0];
            for (int i = 1; i < inArr.Length; i++)
            {
                inArr[i] = chartData[0,i];
            }
            System.Numerics.Complex[] newfft = DSP.FFT(inArr);
            for (UInt32 i = index; i < numPointPerLine; i++)
            {
                chart1.Series[0].Points.Add(chartData[0,i]);
            }
            for (int i = 0; i < index; i++)
            {
                chart1.Series[0].Points.Add(chartData[0,i]);
            }
            for (int i = 0; i < numPointPerLine; i++)
            {
                fft_mag[i] = newfft[i].Magnitude;
            }
            for (int i = 0; i < fft_mag.Length; i++)
            {
                chart1.Series[1].Points.Add(fft_mag[i] / 4 - 20);
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
                chart1.Series[2].Points.Add(spikes.ElementAt(i) / 4 - 20);
            }
        }

        private void toolStripButton_Start_Click(object sender, EventArgs e)
        {
            UInt32 delay;
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
                byte[] buf = new byte[frameLen] { 0, 0, 0 };
                while (fs.Position < fs.Length)
                {
                    if (buf[0] == 0xA5)
                    {
                        index = (index + 1) % numPointPerLine;
                        chartData[0,index] = BitConverter.ToInt16(buf, 1);
                        for (int i = 0; i < frameLen; i++)
                        {
                            buf[i] = (byte)fs.ReadByte();
                        }
                    }
                    else
                    {
                        for (int i = 0; i < frameLen - 1; i++)
                        {
                            buf[i] = buf[i + 1];
                        }
                        buf[frameLen - 1] = (byte)fs.ReadByte();
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

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.Minimum = -minChartRange * Math.Pow(2, toolStripComboBox1.SelectedIndex);
            chart1.ChartAreas[0].AxisY.Maximum = minChartRange * Math.Pow(2, toolStripComboBox1.SelectedIndex);
        }

        private void toolStripButton_Config_Click(object sender, EventArgs e)
        {
            FormConfig frmConfig = new FormConfig();
            if (frmConfig.ShowDialog() == DialogResult.OK)
            {
                if (frmConfig.dataSrc == DataSource.File)
                {
                    FileData fd = new FileData();
                    fd.buf1 = buf1;
                    originalDataDevice = frmConfig.dataSrcName;
                    originalData = fd;
                }
                else if (frmConfig.dataSrc == DataSource.COM)
                {
                    originalData = new COMData();
                    originalDataDevice = serialPort1;
                }
                else if (frmConfig.dataSrc == DataSource.WIFI)
                {
                    WifiData wd = new WifiData();
                    wd.buf1 = buf1;
                    originalData = wd;
                }
                originalData.onEvent += new TimerCallback(onStopMeasure);
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
    class COMData : sampleData
    {
        System.IO.Ports.SerialPort thePort;
        public override void Start(object src)
        {
            try
            {
                thePort = src as System.IO.Ports.SerialPort;
                thePort.Open();
            }
            catch (Exception ex) { }
        }
        public override void Stop()
        {
            lock (thePort)
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
        public override void Start(object src)
        {
            _Text = src.ToString();
            System.Threading.Thread thrd = new Thread(new System.Threading.ParameterizedThreadStart(loadData));
            System.Console.WriteLine("begin");
            thrd.Start(src as string);
        }
        public override void Stop()
        {
            isRunning = false;
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
            System.Net.Sockets.UdpClient s = new System.Net.Sockets.UdpClient(60000);
            System.Net.IPAddress _addr = new System.Net.IPAddress(new byte[] { 192, 168, 2, 1 });
            System.Net.IPEndPoint _ep = new System.Net.IPEndPoint(_addr, 8000);
            s.Send(new byte[] { 0xaa }, 1, _ep);
            isRunning = true;
            while (isRunning == true)
            {
                byte[] recvBuf=s.Receive(ref _ep);
                int pos = 0;
                byte[] package = new byte[100];
                while (pos < recvBuf.Length)
                {
                    Array.Copy(recvBuf, pos, package, 0, 100);
                    for (int i = 2; i < package.Length-2; i += 6)
                    {
                        buf1.Put(0xA5);
                        buf1.Put(package[i]);
                        buf1.Put(package[i+1]);
                    }
                    pos += 100;

                }
            }
            s.Send(new byte[] { 0xbb }, 1, _ep);
            s.Close();
            onEvent("Stopped");
        }

    }
}
