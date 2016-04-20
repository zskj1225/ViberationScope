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
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine1 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine2 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.SystemColors.MenuHighlight, System.Drawing.Color.Empty, new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViberationScope));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chart_Wave = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Vibrator_title = new System.Windows.Forms.ToolStripStatusLabel();
            this.Vibrator_result = new System.Windows.Forms.ToolStripStatusLabel();
            this.frequency = new System.Windows.Forms.ToolStripStatusLabel();
            this.F0_result = new System.Windows.Forms.ToolStripStatusLabel();
            this.Force_title = new System.Windows.Forms.ToolStripStatusLabel();
            this.Force_result = new System.Windows.Forms.ToolStripStatusLabel();
            this.unit = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Wifi_list = new System.Windows.Forms.ListView();
            this.VibratorList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripButton_Start = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Stop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Fresh_button = new System.Windows.Forms.ToolStripButton();
            this.ChoiceData_button = new System.Windows.Forms.ToolStripButton();
            this.AddDdata_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Open = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.Multiple_ComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.Frequency_Label1 = new System.Windows.Forms.ToolStripLabel();
            this.Frequency_box1 = new System.Windows.Forms.ToolStripTextBox();
            this.Frequency_Label2 = new System.Windows.Forms.ToolStripLabel();
            this.Frequency_box2 = new System.Windows.Forms.ToolStripTextBox();
            this.Wavedifference_Label3 = new System.Windows.Forms.ToolStripLabel();
            this.Wavedifference_box = new System.Windows.Forms.ToolStripTextBox();
            this.Toplist_toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_zoom = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Wave)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Toplist_toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // chart_Wave
            // 
            this.chart_Wave.BorderlineColor = System.Drawing.Color.Black;
            this.chart_Wave.BorderSkin.BorderWidth = 2;
            this.chart_Wave.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chart_Wave.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.SharpTriangle;
            customLabel1.ForeColor = System.Drawing.Color.Green;
            customLabel1.FromPosition = 400D;
            customLabel1.MarkColor = System.Drawing.Color.Red;
            chartArea1.AxisX.CustomLabels.Add(customLabel1);
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.DarkOrange;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.LabelStyle.Angle = 5;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Lime;
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Blue;
            chartArea1.AxisX.LineWidth = 5;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Blue;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Blue;
            chartArea1.AxisX.MajorTickMark.Size = 8F;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisX.Maximum = 200D;
            chartArea1.AxisX.MaximumAutoSize = 50F;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.MinorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Yellow;
            chartArea1.AxisX.MinorGrid.LineWidth = 3;
            chartArea1.AxisX.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Blue;
            stripLine1.BackColor = System.Drawing.Color.Lime;
            stripLine1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            stripLine1.ForeColor = System.Drawing.Color.Chartreuse;
            stripLine1.Text = "X";
            stripLine1.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX.StripLines.Add(stripLine1);
            chartArea1.AxisX.Title = "点集数";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Tai Le", 8F);
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Lime;
            chartArea1.AxisX2.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisX2.InterlacedColor = System.Drawing.Color.Black;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.Black;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Blue;
            chartArea1.AxisY.LineWidth = 5;
            chartArea1.AxisY.MajorTickMark.Interval = 0D;
            chartArea1.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Blue;
            chartArea1.AxisY.MajorTickMark.Size = 5F;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisY.Maximum = 1024D;
            chartArea1.AxisY.Minimum = -1024D;
            chartArea1.AxisY.StripLines.Add(stripLine2);
            chartArea1.AxisY2.InterlacedColor = System.Drawing.Color.Black;
            chartArea1.AxisY2.IsInterlaced = true;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 100F;
            chartArea1.InnerPlotPosition.Width = 100F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.chart_Wave.ChartAreas.Add(chartArea1);
            this.chart_Wave.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chart_Wave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart_Wave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            legend1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopRight;
            legend1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipXY;
            legend1.BorderColor = System.Drawing.Color.Black;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chart_Wave.Legends.Add(legend1);
            this.chart_Wave.Location = new System.Drawing.Point(0, 0);
            this.chart_Wave.Name = "chart_Wave";
            series1.BackImageTransparentColor = System.Drawing.Color.Silver;
            series1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsXValueIndexed = true;
            series1.LabelFormat = "\"N1\"";
            series1.Legend = "Legend1";
            series1.Name = "时域曲线";
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series1.ToolTip = "时域曲线\\n";
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Maroon;
            series2.MarkerBorderWidth = 3;
            series2.MarkerColor = System.Drawing.Color.Red;
            series2.MarkerImageTransparentColor = System.Drawing.Color.Red;
            series2.MarkerSize = 30;
            series2.Name = "频域曲线";
            dataPoint1.ToolTip = "\"#VALX#VALY\";";
            series2.Points.Add(dataPoint1);
            series2.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.DarkOrange;
            series2.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.Box;
            series2.ToolTip = "线类别：频域曲线\\nX轴坐标:#VALX\\nY轴坐标:#VALY\\n";
            series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Enabled = false;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Enabled = false;
            series4.Legend = "Legend1";
            series4.Name = "Series4";
            this.chart_Wave.Series.Add(series1);
            this.chart_Wave.Series.Add(series2);
            this.chart_Wave.Series.Add(series3);
            this.chart_Wave.Series.Add(series4);
            this.chart_Wave.Size = new System.Drawing.Size(550, 329);
            this.chart_Wave.TabIndex = 1;
            this.chart_Wave.Text = "char_Wave";
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.DockedToChartArea = "ChartArea1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            title1.ForeColor = System.Drawing.Color.Green;
            title1.Name = "Title";
            title1.Text = "塔线振动时域频域图";
            title1.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Embed;
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.BackColor = System.Drawing.Color.Transparent;
            title2.BorderWidth = 0;
            title2.DockedToChartArea = "ChartArea1";
            title2.DockingOffset = -10;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            title2.ForeColor = System.Drawing.Color.Blue;
            title2.Name = "Y";
            title2.Text = "Y";
            title3.Alignment = System.Drawing.ContentAlignment.BottomRight;
            title3.BackColor = System.Drawing.Color.Transparent;
            title3.DockedToChartArea = "ChartArea1";
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            title3.ForeColor = System.Drawing.Color.Blue;
            title3.Name = "X";
            title3.Text = "X";
            title4.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            title4.BackColor = System.Drawing.Color.Transparent;
            title4.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.BottomLeft;
            title4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            title4.DockedToChartArea = "ChartArea1";
            title4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title4.DockingOffset = 15;
            title4.ForeColor = System.Drawing.Color.Blue;
            title4.Name = "Kedu1";
            title4.Position.Auto = false;
            title4.Position.Height = 5.306783F;
            title4.Position.X = 26F;
            title4.Position.Y = 90F;
            title4.Text = "50";
            title4.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            title4.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Frame;
            title4.Visible = false;
            title5.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            title5.BackColor = System.Drawing.Color.Transparent;
            title5.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
            title5.DockedToChartArea = "ChartArea1";
            title5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
            title5.DockingOffset = 50;
            title5.ForeColor = System.Drawing.Color.Blue;
            title5.Name = "kedu2";
            title5.Position.Auto = false;
            title5.Position.Height = 5.306783F;
            title5.Position.X = 50F;
            title5.Position.Y = 90F;
            title5.Text = "100";
            title5.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            title5.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Frame;
            title5.Visible = false;
            title6.BackColor = System.Drawing.Color.Transparent;
            title6.DockedToChartArea = "ChartArea1";
            title6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
            title6.DockingOffset = 15;
            title6.ForeColor = System.Drawing.Color.Blue;
            title6.Name = "kedu3";
            title6.Position.Auto = false;
            title6.Position.Height = 10F;
            title6.Position.X = 76F;
            title6.Position.Y = 90F;
            title6.Text = "150";
            title6.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            title6.Visible = false;
            this.chart_Wave.Titles.Add(title1);
            this.chart_Wave.Titles.Add(title2);
            this.chart_Wave.Titles.Add(title3);
            this.chart_Wave.Titles.Add(title4);
            this.chart_Wave.Titles.Add(title5);
            this.chart_Wave.Titles.Add(title6);
            this.chart_Wave.Click += new System.EventHandler(this.chart_Wave_Click);
            this.chart_Wave.MouseCaptureChanged += new System.EventHandler(this.chart_Wave_MouseCaptureChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Vibrator_title,
            this.Vibrator_result,
            this.frequency,
            this.F0_result,
            this.Force_title,
            this.Force_result,
            this.unit});
            this.statusStrip1.Location = new System.Drawing.Point(0, 354);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(678, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Vibrator_title
            // 
            this.Vibrator_title.Name = "Vibrator_title";
            this.Vibrator_title.Size = new System.Drawing.Size(92, 17);
            this.Vibrator_title.Text = "振子连接状态：";
            // 
            // Vibrator_result
            // 
            this.Vibrator_result.BackColor = System.Drawing.Color.Black;
            this.Vibrator_result.ForeColor = System.Drawing.Color.Green;
            this.Vibrator_result.Name = "Vibrator_result";
            this.Vibrator_result.Size = new System.Drawing.Size(77, 17);
            this.Vibrator_result.Text = "等待连接中...";
            // 
            // frequency
            // 
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(64, 17);
            this.frequency.Text = "    基频F0:";
            // 
            // F0_result
            // 
            this.F0_result.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.F0_result.ForeColor = System.Drawing.Color.Green;
            this.F0_result.Name = "F0_result";
            this.F0_result.Size = new System.Drawing.Size(77, 17);
            this.F0_result.Text = "等待计算中...";
            this.F0_result.TextChanged += new System.EventHandler(this.F0_result_TextChanged);
            // 
            // Force_title
            // 
            this.Force_title.Name = "Force_title";
            this.Force_title.Size = new System.Drawing.Size(75, 17);
            this.Force_title.Text = "    拉力结果:";
            // 
            // Force_result
            // 
            this.Force_result.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Force_result.ForeColor = System.Drawing.Color.Green;
            this.Force_result.Name = "Force_result";
            this.Force_result.Size = new System.Drawing.Size(77, 17);
            this.Force_result.Text = "等待计算中...";
            // 
            // unit
            // 
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(38, 17);
            this.unit.Text = "N(牛)";
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
            this.splitContainer1.SplitterDistance = 124;
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
            this.Wifi_list.Size = new System.Drawing.Size(124, 329);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "N";
            // 
            // toolStripButton_Start
            // 
            this.toolStripButton_Start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Start.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Start.Image")));
            this.toolStripButton_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Start.Name = "toolStripButton_Start";
            this.toolStripButton_Start.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Start.Text = "开始";
            this.toolStripButton_Start.ToolTipText = "开始接收";
            this.toolStripButton_Start.Click += new System.EventHandler(this.toolStripButton_Start_Click);
            this.toolStripButton_Start.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripButton_Start_MouseUp);
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
            this.toolStripButton_Stop.ToolTipText = "停止接收";
            this.toolStripButton_Stop.Click += new System.EventHandler(this.toolStripButton_Stop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.Fresh_button.ToolTipText = "刷新振子列表";
            this.Fresh_button.Click += new System.EventHandler(this.toolStripButton_Config_Click);
            // 
            // ChoiceData_button
            // 
            this.ChoiceData_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChoiceData_button.ForeColor = System.Drawing.Color.Black;
            this.ChoiceData_button.Image = ((System.Drawing.Image)(resources.GetObject("ChoiceData_button.Image")));
            this.ChoiceData_button.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.ChoiceData_button.Name = "ChoiceData_button";
            this.ChoiceData_button.Size = new System.Drawing.Size(23, 22);
            this.ChoiceData_button.Text = "参数数据";
            this.ChoiceData_button.ToolTipText = "导入塔线参数";
            this.ChoiceData_button.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // AddDdata_button
            // 
            this.AddDdata_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddDdata_button.Image = ((System.Drawing.Image)(resources.GetObject("AddDdata_button.Image")));
            this.AddDdata_button.ImageTransparentColor = System.Drawing.Color.White;
            this.AddDdata_button.Name = "AddDdata_button";
            this.AddDdata_button.Size = new System.Drawing.Size(23, 22);
            this.AddDdata_button.Text = "manage_Button";
            this.AddDdata_button.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.Multiple_ComboBox.ToolTipText = "波形缩放";
            this.Multiple_ComboBox.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // Frequency_Label1
            // 
            this.Frequency_Label1.Name = "Frequency_Label1";
            this.Frequency_Label1.Size = new System.Drawing.Size(51, 22);
            this.Frequency_Label1.Text = "频点1：";
            // 
            // Frequency_box1
            // 
            this.Frequency_box1.Name = "Frequency_box1";
            this.Frequency_box1.ReadOnly = true;
            this.Frequency_box1.Size = new System.Drawing.Size(50, 25);
            this.Frequency_box1.ToolTipText = "频点";
            // 
            // Frequency_Label2
            // 
            this.Frequency_Label2.Name = "Frequency_Label2";
            this.Frequency_Label2.Size = new System.Drawing.Size(51, 22);
            this.Frequency_Label2.Text = "频点2：";
            // 
            // Frequency_box2
            // 
            this.Frequency_box2.Name = "Frequency_box2";
            this.Frequency_box2.ReadOnly = true;
            this.Frequency_box2.Size = new System.Drawing.Size(50, 23);
            this.Frequency_box2.ToolTipText = "频点";
            // 
            // Wavedifference_Label3
            // 
            this.Wavedifference_Label3.Name = "Wavedifference_Label3";
            this.Wavedifference_Label3.Size = new System.Drawing.Size(56, 17);
            this.Wavedifference_Label3.Text = "谐波差数";
            // 
            // Wavedifference_box
            // 
            this.Wavedifference_box.Name = "Wavedifference_box";
            this.Wavedifference_box.ReadOnly = true;
            this.Wavedifference_box.Size = new System.Drawing.Size(100, 23);
            this.Wavedifference_box.ToolTipText = "谐波差数";
            // 
            // Toplist_toolStrip
            // 
            this.Toplist_toolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.Toplist_toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Start,
            this.toolStripButton_Stop,
            this.toolStripSeparator1,
            this.Fresh_button,
            this.ChoiceData_button,
            this.AddDdata_button,
            this.toolStripSeparator2,
            this.toolStripButton_Open,
            this.toolStripButton_Save,
            this.toolStripSeparator3,
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.toolStripLabel_zoom,
            this.Multiple_ComboBox,
            this.toolStripSeparator4,
            this.Frequency_Label1,
            this.Frequency_box1,
            this.Frequency_Label2,
            this.Frequency_box2,
            this.Wavedifference_Label3,
            this.Wavedifference_box,
            this.toolStripSeparator5});
            this.Toplist_toolStrip.Location = new System.Drawing.Point(0, 0);
            this.Toplist_toolStrip.Name = "Toplist_toolStrip";
            this.Toplist_toolStrip.Size = new System.Drawing.Size(678, 25);
            this.Toplist_toolStrip.TabIndex = 3;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_zoom
            // 
            this.toolStripLabel_zoom.Name = "toolStripLabel_zoom";
            this.toolStripLabel_zoom.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel_zoom.Text = "波形缩放：";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 6);
            // 
            // ViberationScope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 376);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Toplist_toolStrip);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Name = "ViberationScope";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "张力测试仪";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Wave)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Toplist_toolStrip.ResumeLayout(false);
            this.Toplist_toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Wave;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Vibrator_result;
        private System.Windows.Forms.ToolStripStatusLabel Vibrator_title;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView Wifi_list;
        private System.Windows.Forms.ToolStripStatusLabel Force_title;
        private System.Windows.Forms.ToolStripStatusLabel Force_result;
        public System.Windows.Forms.ColumnHeader VibratorList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel unit;
        private System.Windows.Forms.ToolStripStatusLabel frequency;
        private System.Windows.Forms.ToolStripStatusLabel F0_result;
        private System.Windows.Forms.ToolStripButton toolStripButton_Start;
        private System.Windows.Forms.ToolStripButton toolStripButton_Stop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Fresh_button;
        private System.Windows.Forms.ToolStripButton ChoiceData_button;
        private System.Windows.Forms.ToolStripButton AddDdata_button;
        private System.Windows.Forms.ToolStripButton toolStripButton_Open;
        private System.Windows.Forms.ToolStripButton toolStripButton_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripComboBox Multiple_ComboBox;
        private System.Windows.Forms.ToolStripLabel Frequency_Label1;
        private System.Windows.Forms.ToolStripTextBox Frequency_box1;
        private System.Windows.Forms.ToolStripLabel Frequency_Label2;
        private System.Windows.Forms.ToolStripTextBox Frequency_box2;
        private System.Windows.Forms.ToolStripLabel Wavedifference_Label3;
        private System.Windows.Forms.ToolStripTextBox Wavedifference_box;
        private System.Windows.Forms.ToolStrip Toplist_toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_zoom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

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

