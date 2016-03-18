using System.Data;

namespace ViberationScope
{
    partial class ViberationScope
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViberationScope));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.SystemColors.MenuHighlight, System.Drawing.Color.Empty, new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chart_Wave = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Vibrator_label1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Vibrator_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.Force_label1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Force_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Start = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Stop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Open = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Fresh_button = new System.Windows.Forms.ToolStripButton();
            this.AddDdata_button = new System.Windows.Forms.ToolStripButton();
            this.ChoiceData_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.Multiple_ComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.Frequency_Label1 = new System.Windows.Forms.ToolStripLabel();
            this.Frequency_box1 = new System.Windows.Forms.ToolStripTextBox();
            this.Frequency_Label2 = new System.Windows.Forms.ToolStripLabel();
            this.Frequency_box2 = new System.Windows.Forms.ToolStripTextBox();
            this.Wavedifference_Label3 = new System.Windows.Forms.ToolStripLabel();
            this.Wavedifference_box = new System.Windows.Forms.ToolStripTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Wifi_list = new System.Windows.Forms.ListView();
            this.VibratorList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.chart_Wave)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // chart_Wave
            // 
            chartArea1.AxisY.Maximum = 1024D;
            chartArea1.AxisY.Minimum = -1024D;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 100F;
            chartArea1.InnerPlotPosition.Width = 100F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.chart_Wave.ChartAreas.Add(chartArea1);
            this.chart_Wave.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_Wave.Legends.Add(legend1);
            this.chart_Wave.Location = new System.Drawing.Point(0, 0);
            this.chart_Wave.Name = "chart_Wave";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Acc";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Spikes";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "Series4";
            this.chart_Wave.Series.Add(series1);
            this.chart_Wave.Series.Add(series2);
            this.chart_Wave.Series.Add(series3);
            this.chart_Wave.Series.Add(series4);
            this.chart_Wave.Size = new System.Drawing.Size(548, 329);
            this.chart_Wave.TabIndex = 1;
            this.chart_Wave.Text = "char_Wave";
            this.chart_Wave.Click += new System.EventHandler(this.chart_Wave_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Vibrator_label1,
            this.Vibrator_label,
            this.Force_label1,
            this.Force_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 354);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(678, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Vibrator_label1
            // 
            this.Vibrator_label1.Name = "Vibrator_label1";
            this.Vibrator_label1.Size = new System.Drawing.Size(92, 17);
            this.Vibrator_label1.Text = "振子连接状态：";
            // 
            // Vibrator_label
            // 
            this.Vibrator_label.BackColor = System.Drawing.Color.Black;
            this.Vibrator_label.ForeColor = System.Drawing.Color.Green;
            this.Vibrator_label.Name = "Vibrator_label";
            this.Vibrator_label.Size = new System.Drawing.Size(77, 17);
            this.Vibrator_label.Text = "等待连接中...";
            // 
            // Force_label1
            // 
            this.Force_label1.Name = "Force_label1";
            this.Force_label1.Size = new System.Drawing.Size(59, 17);
            this.Force_label1.Text = "拉力结果:";
            // 
            // Force_label
            // 
            this.Force_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Force_label.ForeColor = System.Drawing.Color.Green;
            this.Force_label.Name = "Force_label";
            this.Force_label.Size = new System.Drawing.Size(77, 17);
            this.Force_label.Text = "等待计算中...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Start,
            this.toolStripButton_Stop,
            this.toolStripSeparator1,
            this.toolStripButton_Open,
            this.toolStripButton_Save,
            this.toolStripSeparator2,
            this.Fresh_button,
            this.AddDdata_button,
            this.ChoiceData_button,
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.Multiple_ComboBox,
            this.Frequency_Label1,
            this.Frequency_box1,
            this.Frequency_Label2,
            this.Frequency_box2,
            this.Wavedifference_Label3,
            this.Wavedifference_box});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(678, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Start
            // 
            this.toolStripButton_Start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Start.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Start.Image")));
            this.toolStripButton_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Start.Name = "toolStripButton_Start";
            this.toolStripButton_Start.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Start.Text = "开始";
            this.toolStripButton_Start.Click += new System.EventHandler(this.toolStripButton_Start_Click);
            // 
            // toolStripButton_Stop
            // 
            this.toolStripButton_Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Stop.Enabled = false;
            this.toolStripButton_Stop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Stop.Image")));
            this.toolStripButton_Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Stop.Name = "toolStripButton_Stop";
            this.toolStripButton_Stop.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Stop.Text = "停止";
            this.toolStripButton_Stop.Click += new System.EventHandler(this.toolStripButton_Stop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_Open
            // 
            this.toolStripButton_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Open.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Open.Image")));
            this.toolStripButton_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Open.Name = "toolStripButton_Open";
            this.toolStripButton_Open.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Open.Text = "打开文件夹";
            this.toolStripButton_Open.Click += new System.EventHandler(this.toolStripButton_Open_Click);
            // 
            // toolStripButton_Save
            // 
            this.toolStripButton_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Save.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Save.Image")));
            this.toolStripButton_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Save.Name = "toolStripButton_Save";
            this.toolStripButton_Save.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Save.Text = "保存";
            this.toolStripButton_Save.Click += new System.EventHandler(this.toolStripButton_Save_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Fresh_button
            // 
            this.Fresh_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Fresh_button.Image = ((System.Drawing.Image)(resources.GetObject("Fresh_button.Image")));
            this.Fresh_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Fresh_button.Name = "Fresh_button";
            this.Fresh_button.RightToLeftAutoMirrorImage = true;
            this.Fresh_button.Size = new System.Drawing.Size(23, 22);
            this.Fresh_button.Text = "刷新网络";
            this.Fresh_button.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.Fresh_button.Click += new System.EventHandler(this.toolStripButton_Config_Click);
            // 
            // AddDdata_button
            // 
            this.AddDdata_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddDdata_button.Image = ((System.Drawing.Image)(resources.GetObject("AddDdata_button.Image")));
            this.AddDdata_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddDdata_button.Name = "AddDdata_button";
            this.AddDdata_button.Size = new System.Drawing.Size(23, 22);
            this.AddDdata_button.Text = "Add_Button1";
            this.AddDdata_button.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ChoiceData_button
            // 
            this.ChoiceData_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChoiceData_button.Image = ((System.Drawing.Image)(resources.GetObject("ChoiceData_button.Image")));
            this.ChoiceData_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChoiceData_button.Name = "ChoiceData_button";
            this.ChoiceData_button.Size = new System.Drawing.Size(23, 22);
            this.ChoiceData_button.Text = "参数数据";
            this.ChoiceData_button.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(70, 25);
            this.toolStripTextBox1.Text = "1";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(70, 25);
            this.toolStripTextBox2.Text = "1000";
            // 
            // Multiple_ComboBox
            // 
            this.Multiple_ComboBox.Items.AddRange(new object[] {
            "1x",
            "2x",
            "4x",
            "8x",
            "16x",
            "32x",
            "64x",
            "128x",
            "256x",
            "512x"});
            this.Multiple_ComboBox.Name = "Multiple_ComboBox";
            this.Multiple_ComboBox.Size = new System.Drawing.Size(80, 25);
            this.Multiple_ComboBox.Text = "波形缩放";
            this.Multiple_ComboBox.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // Frequency_Label1
            // 
            this.Frequency_Label1.Name = "Frequency_Label1";
            this.Frequency_Label1.Size = new System.Drawing.Size(39, 22);
            this.Frequency_Label1.Text = "频点1";
            // 
            // Frequency_box1
            // 
            this.Frequency_box1.Name = "Frequency_box1";
            this.Frequency_box1.Size = new System.Drawing.Size(50, 25);
            // 
            // Frequency_Label2
            // 
            this.Frequency_Label2.Name = "Frequency_Label2";
            this.Frequency_Label2.Size = new System.Drawing.Size(39, 22);
            this.Frequency_Label2.Text = "频点2";
            // 
            // Frequency_box2
            // 
            this.Frequency_box2.Name = "Frequency_box2";
            this.Frequency_box2.Size = new System.Drawing.Size(50, 25);
            // 
            // Wavedifference_Label3
            // 
            this.Wavedifference_Label3.Name = "Wavedifference_Label3";
            this.Wavedifference_Label3.Size = new System.Drawing.Size(56, 22);
            this.Wavedifference_Label3.Text = "谐波差数";
            // 
            // Wavedifference_box
            // 
            this.Wavedifference_box.Name = "Wavedifference_box";
            this.Wavedifference_box.Size = new System.Drawing.Size(100, 23);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Wifi_list);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart_Wave);
            this.splitContainer1.Size = new System.Drawing.Size(678, 329);
            this.splitContainer1.SplitterDistance = 126;
            this.splitContainer1.TabIndex = 4;
            // 
            // Wifi_list
            // 
            this.Wifi_list.BackColor = System.Drawing.SystemColors.Window;
            this.Wifi_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.VibratorList});
            this.Wifi_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wifi_list.Font = new System.Drawing.Font("宋体", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Wifi_list.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Wifi_list.FullRowSelect = true;
            this.Wifi_list.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.Wifi_list.Location = new System.Drawing.Point(0, 0);
            this.Wifi_list.Name = "Wifi_list";
            this.Wifi_list.Size = new System.Drawing.Size(126, 329);
            this.Wifi_list.TabIndex = 0;
            this.Wifi_list.TileSize = new System.Drawing.Size(50, 50);
            this.Wifi_list.UseCompatibleStateImageBehavior = false;
            this.Wifi_list.View = System.Windows.Forms.View.Details;
            this.Wifi_list.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // VibratorList
            // 
            this.VibratorList.Text = "振子列表";
            this.VibratorList.Width = 212;
            // 
            // ViberationScope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 376);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "ViberationScope";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "张力测试仪";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Wave)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Wave;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Vibrator_label;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Start;
        private System.Windows.Forms.ToolStripButton toolStripButton_Stop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Open;
        private System.Windows.Forms.ToolStripButton toolStripButton_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox Multiple_ComboBox;
        private System.Windows.Forms.ToolStripStatusLabel Vibrator_label1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripButton Fresh_button;
        private System.Windows.Forms.ToolStripButton AddDdata_button;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView Wifi_list;
        private System.Windows.Forms.ToolStripStatusLabel Force_label1;
        private System.Windows.Forms.ToolStripStatusLabel Force_label;
        private System.Windows.Forms.ToolStripLabel Frequency_Label1;
        private System.Windows.Forms.ToolStripTextBox Frequency_box1;
        private System.Windows.Forms.ToolStripLabel Frequency_Label2;
        private System.Windows.Forms.ToolStripTextBox Frequency_box2;
        private System.Windows.Forms.ToolStripLabel Wavedifference_Label3;
        private System.Windows.Forms.ToolStripTextBox Wavedifference_box;
        private System.Windows.Forms.ToolStripButton ChoiceData_button;
        public System.Windows.Forms.ColumnHeader VibratorList;

        internal class firstDataSet
        {
        }

        internal class firstDataSet2
        {
            internal string DataSetName;
            internal SchemaSerializationMode SchemaSerializationMode;

            public firstDataSet2()
            {
            }
        }
    }
}

