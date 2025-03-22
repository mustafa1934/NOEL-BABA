namespace NOEL_BABA
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startConnect = new System.Windows.Forms.Button();
            this.stopConnect = new System.Windows.Forms.Button();
            this.Ports = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Temperature1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Pressure1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Altitude1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Voltage1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.camPorts = new System.Windows.Forms.ComboBox();
            this.fpvCam = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startCam = new System.Windows.Forms.Button();
            this.stopCam = new System.Windows.Forms.Button();
            this.startRecordCam = new System.Windows.Forms.Button();
            this.stpRecordCam = new System.Windows.Forms.Button();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.haritaGetir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Seriport = new System.Windows.Forms.GroupBox();
            this.Kamera = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.glControl1 = new OpenTK.GLControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ayril = new System.Windows.Forms.Button();
            this.birles = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Temperature1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pressure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Altitude1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Voltage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpvCam)).BeginInit();
            this.Seriport.SuspendLayout();
            this.Kamera.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startConnect
            // 
            this.startConnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startConnect.Location = new System.Drawing.Point(44, 84);
            this.startConnect.Name = "startConnect";
            this.startConnect.Size = new System.Drawing.Size(80, 35);
            this.startConnect.TabIndex = 0;
            this.startConnect.Text = "Başlat";
            this.startConnect.UseVisualStyleBackColor = true;
            this.startConnect.Click += new System.EventHandler(this.startConnect_Click);
            // 
            // stopConnect
            // 
            this.stopConnect.Location = new System.Drawing.Point(164, 84);
            this.stopConnect.Name = "stopConnect";
            this.stopConnect.Size = new System.Drawing.Size(78, 35);
            this.stopConnect.TabIndex = 1;
            this.stopConnect.Text = "Durdur";
            this.stopConnect.UseVisualStyleBackColor = true;
            this.stopConnect.Click += new System.EventHandler(this.stopConnect_Click);
            // 
            // Ports
            // 
            this.Ports.BackColor = System.Drawing.Color.LightCyan;
            this.Ports.FormattingEnabled = true;
            this.Ports.Location = new System.Drawing.Point(96, 38);
            this.Ports.Name = "Ports";
            this.Ports.Size = new System.Drawing.Size(121, 24);
            this.Ports.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(474, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(735, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Temperature1
            // 
            this.Temperature1.BackColor = System.Drawing.Color.LightCyan;
            chartArea13.Name = "ChartArea1";
            this.Temperature1.ChartAreas.Add(chartArea13);
            this.Temperature1.Location = new System.Drawing.Point(491, 157);
            this.Temperature1.Name = "Temperature1";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Name = "temperature1";
            this.Temperature1.Series.Add(series13);
            this.Temperature1.Size = new System.Drawing.Size(355, 269);
            this.Temperature1.TabIndex = 4;
            this.Temperature1.Text = "chart1";
            // 
            // Pressure1
            // 
            this.Pressure1.BackColor = System.Drawing.Color.LightCyan;
            chartArea14.Name = "ChartArea1";
            this.Pressure1.ChartAreas.Add(chartArea14);
            this.Pressure1.Location = new System.Drawing.Point(965, 146);
            this.Pressure1.Name = "Pressure1";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Name = "pressure1";
            this.Pressure1.Series.Add(series14);
            this.Pressure1.Size = new System.Drawing.Size(347, 269);
            this.Pressure1.TabIndex = 5;
            this.Pressure1.Text = "chart2";
            // 
            // Altitude1
            // 
            this.Altitude1.BackColor = System.Drawing.Color.LightCyan;
            chartArea15.Name = "ChartArea1";
            this.Altitude1.ChartAreas.Add(chartArea15);
            this.Altitude1.Location = new System.Drawing.Point(491, 558);
            this.Altitude1.Name = "Altitude1";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Name = "altitude1";
            this.Altitude1.Series.Add(series15);
            this.Altitude1.Size = new System.Drawing.Size(355, 269);
            this.Altitude1.TabIndex = 4;
            this.Altitude1.Text = "chart1";
            // 
            // Voltage1
            // 
            this.Voltage1.BackColor = System.Drawing.Color.LightCyan;
            this.Voltage1.BorderlineColor = System.Drawing.Color.LightCyan;
            chartArea16.Name = "ChartArea1";
            this.Voltage1.ChartAreas.Add(chartArea16);
            this.Voltage1.Location = new System.Drawing.Point(965, 558);
            this.Voltage1.Name = "Voltage1";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Name = "voltage1";
            this.Voltage1.Series.Add(series16);
            this.Voltage1.Size = new System.Drawing.Size(347, 269);
            this.Voltage1.TabIndex = 5;
            this.Voltage1.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seri Port";
            // 
            // camPorts
            // 
            this.camPorts.FormattingEnabled = true;
            this.camPorts.Location = new System.Drawing.Point(82, 17);
            this.camPorts.Name = "camPorts";
            this.camPorts.Size = new System.Drawing.Size(121, 24);
            this.camPorts.TabIndex = 7;
            // 
            // fpvCam
            // 
            this.fpvCam.Location = new System.Drawing.Point(9, 365);
            this.fpvCam.Name = "fpvCam";
            this.fpvCam.Size = new System.Drawing.Size(460, 422);
            this.fpvCam.TabIndex = 8;
            this.fpvCam.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kamera";
            // 
            // startCam
            // 
            this.startCam.Location = new System.Drawing.Point(30, 51);
            this.startCam.Name = "startCam";
            this.startCam.Size = new System.Drawing.Size(75, 39);
            this.startCam.TabIndex = 10;
            this.startCam.Text = "Aç";
            this.startCam.UseVisualStyleBackColor = true;
            this.startCam.Click += new System.EventHandler(this.startCam_Click);
            // 
            // stopCam
            // 
            this.stopCam.BackColor = System.Drawing.SystemColors.Control;
            this.stopCam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.stopCam.Location = new System.Drawing.Point(150, 51);
            this.stopCam.Name = "stopCam";
            this.stopCam.Size = new System.Drawing.Size(75, 39);
            this.stopCam.TabIndex = 11;
            this.stopCam.Text = "Kapat";
            this.stopCam.UseVisualStyleBackColor = false;
            this.stopCam.Click += new System.EventHandler(this.stopCam_Click);
            // 
            // startRecordCam
            // 
            this.startRecordCam.Location = new System.Drawing.Point(30, 96);
            this.startRecordCam.Name = "startRecordCam";
            this.startRecordCam.Size = new System.Drawing.Size(75, 41);
            this.startRecordCam.TabIndex = 12;
            this.startRecordCam.Text = "Kaydet";
            this.startRecordCam.UseVisualStyleBackColor = true;
            this.startRecordCam.Click += new System.EventHandler(this.startRecordCam_Click);
            // 
            // stpRecordCam
            // 
            this.stpRecordCam.Location = new System.Drawing.Point(150, 96);
            this.stpRecordCam.Name = "stpRecordCam";
            this.stpRecordCam.Size = new System.Drawing.Size(75, 41);
            this.stpRecordCam.TabIndex = 13;
            this.stpRecordCam.Text = "Durdur";
            this.stpRecordCam.UseVisualStyleBackColor = true;
            this.stpRecordCam.Click += new System.EventHandler(this.stpRecordCam_Click);
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(100, 53);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(100, 22);
            this.txtLat.TabIndex = 14;
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(100, 90);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(100, 22);
            this.txtLong.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "latitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "longitude";
            // 
            // map
            // 
            this.map.BackColor = System.Drawing.Color.LightCyan;
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Honeydew;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(1374, 367);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(515, 406);
            this.map.TabIndex = 18;
            this.map.Zoom = 0D;
            // 
            // haritaGetir
            // 
            this.haritaGetir.Location = new System.Drawing.Point(230, 61);
            this.haritaGetir.Name = "haritaGetir";
            this.haritaGetir.Size = new System.Drawing.Size(87, 38);
            this.haritaGetir.TabIndex = 19;
            this.haritaGetir.Text = "H.Getir";
            this.haritaGetir.UseVisualStyleBackColor = true;
            this.haritaGetir.Click += new System.EventHandler(this.haritaGetir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(629, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sıcaklık";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1120, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Basınç";
            // 
            // Seriport
            // 
            this.Seriport.Controls.Add(this.Ports);
            this.Seriport.Controls.Add(this.startConnect);
            this.Seriport.Controls.Add(this.stopConnect);
            this.Seriport.Controls.Add(this.label1);
            this.Seriport.Location = new System.Drawing.Point(9, 210);
            this.Seriport.Name = "Seriport";
            this.Seriport.Size = new System.Drawing.Size(262, 149);
            this.Seriport.TabIndex = 22;
            this.Seriport.TabStop = false;
            // 
            // Kamera
            // 
            this.Kamera.Controls.Add(this.camPorts);
            this.Kamera.Controls.Add(this.label2);
            this.Kamera.Controls.Add(this.startCam);
            this.Kamera.Controls.Add(this.stopCam);
            this.Kamera.Controls.Add(this.startRecordCam);
            this.Kamera.Controls.Add(this.stpRecordCam);
            this.Kamera.Location = new System.Drawing.Point(9, 793);
            this.Kamera.Name = "Kamera";
            this.Kamera.Size = new System.Drawing.Size(259, 139);
            this.Kamera.TabIndex = 23;
            this.Kamera.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLat);
            this.groupBox1.Controls.Add(this.txtLong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.haritaGetir);
            this.groupBox1.Location = new System.Drawing.Point(1449, 779);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 151);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(26, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(195, 175);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 25;
            this.logo.TabStop = false;
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.LightCyan;
            this.glControl1.Location = new System.Drawing.Point(1374, 35);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(515, 324);
            this.glControl1.TabIndex = 26;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(910, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "x";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1017, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "z";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(962, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "y";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(891, 46);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(51, 16);
            this.lblX.TabIndex = 33;
            this.lblX.Text = "label10";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(943, 46);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(51, 16);
            this.lblY.TabIndex = 34;
            this.lblY.Text = "label11";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(1001, 46);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(51, 16);
            this.lblZ.TabIndex = 35;
            this.lblZ.Text = "label12";
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(569, 13);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 23);
            this.btnX.TabIndex = 36;
            this.btnX.Text = "x";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnY
            // 
            this.btnY.Location = new System.Drawing.Point(684, 12);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(75, 22);
            this.btnY.TabIndex = 37;
            this.btnY.Text = "y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // btnZ
            // 
            this.btnZ.Location = new System.Drawing.Point(798, 12);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(75, 23);
            this.btnZ.TabIndex = 38;
            this.btnZ.Text = "z";
            this.btnZ.UseVisualStyleBackColor = true;
            this.btnZ.Click += new System.EventHandler(this.btnZ_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(632, 853);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 24);
            this.label10.TabIndex = 39;
            this.label10.Text = "Yükseklik";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(1123, 852);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 24);
            this.label11.TabIndex = 40;
            this.label11.Text = "Pil Gerilimi";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(228, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(203, 87);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(8, 13);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 32);
            this.label14.TabIndex = 1;
            this.label14.Text = "TECH-SAT";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(0, 45);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Takım Numarası: 288261";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(408, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 24);
            this.label13.TabIndex = 42;
            this.label13.Text = "Veriler*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label15.Location = new System.Drawing.Point(12, 990);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(220, 16);
            this.label15.TabIndex = 43;
            this.label15.Text = "© Copyrigt By TECH-SAT 2023 ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label16.Location = new System.Drawing.Point(1545, 983);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(320, 23);
            this.label16.TabIndex = 44;
            this.label16.Text = "Designed by Mustafa KOCA & Harun CAN";
            // 
            // ayril
            // 
            this.ayril.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ayril.Location = new System.Drawing.Point(19, 65);
            this.ayril.Name = "ayril";
            this.ayril.Size = new System.Drawing.Size(88, 46);
            this.ayril.TabIndex = 45;
            this.ayril.Text = "Ayrılmayı Gerçekleştir";
            this.ayril.UseVisualStyleBackColor = true;
            this.ayril.Click += new System.EventHandler(this.ayril_Click);
            // 
            // birles
            // 
            this.birles.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birles.Location = new System.Drawing.Point(141, 65);
            this.birles.Name = "birles";
            this.birles.Size = new System.Drawing.Size(88, 46);
            this.birles.TabIndex = 46;
            this.birles.Text = "Birleş";
            this.birles.UseVisualStyleBackColor = true;
            this.birles.Click += new System.EventHandler(this.birles_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ayril);
            this.groupBox2.Controls.Add(this.birles);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(784, 870);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 136);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ayrılma Mekanizması";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Kamera);
            this.Controls.Add(this.Seriport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.map);
            this.Controls.Add(this.fpvCam);
            this.Controls.Add(this.Voltage1);
            this.Controls.Add(this.Pressure1);
            this.Controls.Add(this.Altitude1);
            this.Controls.Add(this.Temperature1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Temperature1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pressure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Altitude1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Voltage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpvCam)).EndInit();
            this.Seriport.ResumeLayout(false);
            this.Seriport.PerformLayout();
            this.Kamera.ResumeLayout(false);
            this.Kamera.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startConnect;
        private System.Windows.Forms.Button stopConnect;
        private System.Windows.Forms.ComboBox Ports;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Temperature1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Pressure1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Altitude1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Voltage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox camPorts;
        private System.Windows.Forms.PictureBox fpvCam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startCam;
        private System.Windows.Forms.Button stopCam;
        private System.Windows.Forms.Button startRecordCam;
        private System.Windows.Forms.Button stpRecordCam;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Button haritaGetir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Seriport;
        private System.Windows.Forms.GroupBox Kamera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox logo;
        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button ayril;
        private System.Windows.Forms.Button birles;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

