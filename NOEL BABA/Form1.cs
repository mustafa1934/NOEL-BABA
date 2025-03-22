using GMap.NET.MapProviders;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using AForge.Video;
using AForge.Video.DirectShow;
using Accord.Video.FFMPEG;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace NOEL_BABA
{
    public partial class Form1 : Form
    {
        int x = 0, y = 0, z = 0;
        bool cx = false, cy = false, cz = false;
        Color renk1 = Color.White, renk2 = Color.Red;
        double temperature = 0;
        double pressure = 0;
        double altitude = 0;
        int gyrox = 0;
        int gyroy = 0;
        int gyroz = 0;
        double latitude = 0;
        double longitude = 0;

        private string data;
        public Form1()
        {
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            InitializeComponent();
        }
        FilterInfoCollection fico;
        VideoCaptureDevice vcd;
        VideoFileWriter videoWriter;  // Video yazıcı nesnesi
        bool isRecording = false;  // Kayıt durumu
        string outputFileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\video_output.avi";
        private void startConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = Ports.Text;
                    serialPort1.BaudRate = 9600;
                    serialPort1.Open();
                    startConnect.Enabled = false;
                    stopConnect.Enabled = true;
                    timer1.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void stopConnect_Click(object sender, EventArgs e)
        {

            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                startConnect.Enabled = true; // Başla butonunu tekrar etkinleştir
                stopConnect.Enabled = false; // Durdur butonunu devre dışı bırak
                timer1.Stop(); // Zamanlayıcıyı durdur
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopConnect.Enabled = false;
            startCam.Enabled = true;
            stopCam.Enabled = false;
            startRecordCam.Enabled = true;
            stpRecordCam.Enabled = false;
            string[] ports = SerialPort.GetPortNames(); //Port isimlerini alır ve diziye atar.
            foreach (string port in ports) //port isimlerini comboBox'ın içine ekler
            {
                Ports.Items.Add(port);
            }
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);//verileri çeker
            fico = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo f in fico)
            {
                camPorts.Items.Add(f.Name);
            }
        }
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialPort1.ReadTimeout = 5000;
            data = serialPort1.ReadLine(); //Burası önemli. data yı \n'e göre okuyor. Burayı kaçırma.
            
            this.Invoke(new EventHandler(displayData_event));
        }
        private void displayData_event(object sender, EventArgs e)
        {
            string[] value = data.Split('*'); //*'a göre datayı parçalıyor.
            temperature = double.Parse(value[0], CultureInfo.InvariantCulture);
            pressure = double.Parse(value[1], CultureInfo.InvariantCulture);

            altitude = double.Parse(value[2], CultureInfo.InvariantCulture);
            gyrox = int.Parse(value[3], CultureInfo.InvariantCulture);
            gyroy = int.Parse(value[4], CultureInfo.InvariantCulture);
            gyroz = int.Parse(value[5], CultureInfo.InvariantCulture);
            //latitude = double.Parse(value[6], CultureInfo.InvariantCulture);
            //longitude = double.Parse(value[7], CultureInfo.InvariantCulture);

            
            textBox1.Text = Convert.ToString(temperature) + '*' + Convert.ToString(pressure) + '*' + Convert.ToString(altitude) + '*' + Convert.ToString(gyrox) + '*' + Convert.ToString(gyroy) + '*' + Convert.ToString(gyroz) ;
            //textBox1.Text = data;




        }

        private void haritaGetir_Click(object sender, EventArgs e)
        {
            double lat = 0;
            double longt = 0;
            if (double.TryParse(txtLat.Text, out lat) && double.TryParse(txtLong.Text, out longt))
            {
                map.MapProvider = GMapProviders.GoogleMap;//Burada google map seçtik bing yahoo falan da olabilirdi.

                map.Position = new PointLatLng(lat, longt);
                map.MinZoom = 3;
                map.MaxZoom = 21;
                map.Zoom = 16;
            }
            else
            {
                // Girilen değer bir sayı değilse, hata mesajı göster
                MessageBox.Show("Lütfen geçerli bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void startCam_Click(object sender, EventArgs e)
        {
            // Eğer herhangi bir kamera seçilmemişse, kullanıcıya uyarı göster
            if (camPorts.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir kamera seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Kameraya başlama işlemi yapılmaz
            }
            
            // Seçilen kameraya moniker ile isim verdik
            vcd = new VideoCaptureDevice(fico[camPorts.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            startCam.Enabled = false;
            stopCam.Enabled = true;
        }
        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            fpvCam.Image = (Bitmap)eventArgs.Frame.Clone();

            // Eğer kayıt yapılıyorsa, yeni frame'i video dosyasına yazıyoruz.
            if (isRecording)
            {
                videoWriter.WriteVideoFrame(eventArgs.Frame);
            }
        }

        private void stopCam_Click(object sender, EventArgs e)
        {
            startCam.Enabled = true;
            stopCam.Enabled = false;
            if (vcd != null && vcd.IsRunning)
            {
                
                vcd.Stop();
                vcd.NewFrame -= Vcd_NewFrame;
            }
            fpvCam.Image = null;

            if (isRecording)
            {
                videoWriter.Close();
                isRecording = false;
                startRecordCam.Enabled = true;
                stpRecordCam.Enabled = false;
            }
        }

        private void startRecordCam_Click(object sender, EventArgs e)
        {
            if (vcd != null && vcd.IsRunning)
            {
                if (!isRecording)
                {
                    // Kayıt başlatılıyor
                    videoWriter = new VideoFileWriter();
                    videoWriter.Open(outputFileName, 640, 480, 15, VideoCodec.MPEG4); // Dosya adı ve çözünürlük ayarlanıyor

                    isRecording = true;
                    startRecordCam.Enabled = false;
                    stpRecordCam.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Lütfen kamerayı başlatınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stpRecordCam_Click(object sender, EventArgs e)
        {
            if (isRecording)
            {
                // Kayıt durduruluyor
                videoWriter.Close();
                isRecording = false;
                startRecordCam.Enabled=true;
                stpRecordCam.Enabled=false;
               
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kullanıcıya çıkmadan önce bir onay penceresi gösterelim
            var result = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                // Kullanıcı "Hayır" derse çıkışı engelle
                e.Cancel = true;
            }
            else
            {
                if (stpRecordCam.Enabled == true)
                {
                    videoWriter.Close();
                    isRecording = false;
                }

                if (stopCam.Enabled == true)
                {
                    vcd.Stop();
                }
            }

            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Pressure1.Series["pressure1"].Points.AddXY(DateTime.Now.ToLongTimeString(), Convert.ToInt32(pressure));
            Altitude1.Series["altitude1"].Points.AddXY(DateTime.Now.ToLongTimeString(), Convert.ToInt32(altitude));
            Temperature1.Series["temperature1"].Points.AddXY(DateTime.Now.ToLongTimeString(), Convert.ToInt32(altitude));
            Voltage1.Series["voltage1"].Points.AddXY(DateTime.Now.ToLongTimeString(),7.1);
            lblX.Text=gyrox.ToString();
            lblY.Text=gyroy.ToString();
            lblZ.Text=gyroz.ToString();
            glControl1.Invalidate();
            serialPort1.DiscardInBuffer();
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            float step = 1.0f;//Adım genişliği çözünürlük
            float topla = step;//Tanpon 
            float radius = 4.0f;//Yarıçağ Modle Uydunun
            GL.Clear(ClearBufferMask.ColorBufferBit);//Buffer temizlenmez ise görüntüler üst üste bine o yüzden temizliyoruz.
            GL.Clear(ClearBufferMask.DepthBufferBit);

            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(1.04f, 4 / 3, 1, 10000);
            Matrix4 lookat = Matrix4.LookAt(25, 0, 0, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.LoadMatrix(ref perspective);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.LoadMatrix(ref lookat);
            GL.Viewport(0, 0, glControl1.Width, glControl1.Height);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Less);

            //Asagidaki fonksiyonlar ile nesneyi hareket ettirmemizi sağlıyor.
            GL.Rotate(x, 1.0, 0.0, 0.0);
            GL.Rotate(z, 0.0, 1.0, 0.0);
            GL.Rotate(y, 0.0, 0.0, 1.0);

            //Çizim Fonksiyonları
            silindir(step, topla, radius, 3, -5);
            koni(0.01f, 0.01f, radius, 3.0f, 3, 5);//Ust koni
            koni(0.01f, 0.01f, radius, 2.0f, -5.0f, -10.0f);//Alt koni
            silindir(0.01f, topla, 0.07f, 9, 3);// rotor      
            //Pervane(Yükseklik,Pervane Uzunluğu,Pervane Genişliği,Pervane açısı)
            silindir(0.01f, topla, 0.2f, 9, 9.3f);
            

            silindir(0.01f, topla, 0.2f, 7.3f, 7f);
            
            //// AŞAĞIDA X, Y, Z EKSEN CİZGELERİ ÇİZDİRİLİYOR
            GL.Begin(BeginMode.Lines);

            GL.Color3(Color.FromArgb(250, 0, 0));
            GL.Vertex3(-1000, 0, 0);
            GL.Vertex3(1000, 0, 0);

            GL.Color3(Color.FromArgb(25, 150, 100));
            GL.Vertex3(0, 0, -1000);
            GL.Vertex3(0, 0, 1000);

            GL.Color3(Color.FromArgb(0, 0, 0));
            GL.Vertex3(0, 1000, 0);
            GL.Vertex3(0, -1000, 0);

            GL.End();
            //GraphicsContext.CurrentContext.VSync = true;
            glControl1.SwapBuffers();
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
            GL.Enable(EnableCap.DepthTest);//sonradan yazdık
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (cx == false)
                cx = true;
            else
                cx = false;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            /* if (cx == true)
             {
                 if (x < 360)
                     x += 5;
                 else
                     x = 0;
                 lblX.Text = x.ToString();
             }
             if (cy == true)
             {
                 if (y < 360)
                     y += 5;
                 else
                     y = 0;
                 lblY.Text = y.ToString();
             }
             if (cz == true)
             {
                 if (z < 360)
                     z += 5;
                 else
                     z = 0;
                 lblZ.Text = z.ToString();
             }*/
            x = gyrox;
            y = gyroy;
            z = gyroz;

            glControl1.Invalidate();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void ayril_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1"); // Arduino'ya 1 komutunu gönder
        }

        private void birles_Click(object sender, EventArgs e)
        {
            serialPort1.Write("2"); // Arduino'ya 2 komutunu gönder
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            if (cy == false)
                cy = true;
            else
                cy = false;
            timer2.Start();
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            if (cz == false)
                cz = true;
            else
                cz = false;
            timer2.Start();
        }

        private void silindir(float step, float topla, float radius, float dikey1, float dikey2)
        {
            float eski_step = 0.1f;
            GL.Begin(BeginMode.Quads);//Y EKSEN CIZIM DAİRENİN
            while (step <= 360)
            {
                renk_ataması(step);
                float ciz1_x = (float)(radius * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey1, ciz1_y);

                float ciz2_x = (float)(radius * Math.Cos((step + 2) * Math.PI / 180F));
                float ciz2_y = (float)(radius * Math.Sin((step + 2) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey1, ciz2_y);

                GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            GL.End();
            GL.Begin(BeginMode.Lines);
            step = eski_step;
            topla = step;
            while (step <= 180)// UST KAPAK
            {
                renk_ataması(step);
                float ciz1_x = (float)(radius * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey1, ciz1_y);

                float ciz2_x = (float)(radius * Math.Cos((step + 180) * Math.PI / 180F));
                float ciz2_y = (float)(radius * Math.Sin((step + 180) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey1, ciz2_y);

                GL.Vertex3(ciz1_x, dikey1, ciz1_y);
                GL.Vertex3(ciz2_x, dikey1, ciz2_y);
                step += topla;
            }
            step = eski_step;
            topla = step;
            while (step <= 180)//ALT KAPAK
            {
                renk_ataması(step);

                float ciz1_x = (float)(radius * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey2, ciz1_y);

                float ciz2_x = (float)(radius * Math.Cos((step + 180) * Math.PI / 180F));
                float ciz2_y = (float)(radius * Math.Sin((step + 180) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);

                GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            GL.End();
        }
        private void koni(float step, float topla, float radius1, float radius2, float dikey1, float dikey2)
        {
            float eski_step = 0.1f;
            GL.Begin(BeginMode.Lines);//Y EKSEN CIZIM DAİRENİN
            while (step <= 360)
            {
                renk_ataması(step);
                float ciz1_x = (float)(radius1 * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius1 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey1, ciz1_y);

                float ciz2_x = (float)(radius2 * Math.Cos(step * Math.PI / 180F));
                float ciz2_y = (float)(radius2 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            GL.End();

            GL.Begin(BeginMode.Lines);
            step = eski_step;
            topla = step;
            while (step <= 180)// UST KAPAK
            {
                renk_ataması(step);
                float ciz1_x = (float)(radius2 * Math.Cos(step * Math.PI / 180F));
                float ciz1_y = (float)(radius2 * Math.Sin(step * Math.PI / 180F));
                GL.Vertex3(ciz1_x, dikey2, ciz1_y);

                float ciz2_x = (float)(radius2 * Math.Cos((step + 180) * Math.PI / 180F));
                float ciz2_y = (float)(radius2 * Math.Sin((step + 180) * Math.PI / 180F));
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);

                GL.Vertex3(ciz1_x, dikey2, ciz1_y);
                GL.Vertex3(ciz2_x, dikey2, ciz2_y);
                step += topla;
            }
            step = eski_step;
            topla = step;
            GL.End();
        }
        private void renk_ataması(float step)
        {
            if (step < 45)
                GL.Color3(renk2);
            else if (step < 90)
                GL.Color3(renk1);
            else if (step < 135)
                GL.Color3(renk2);
            else if (step < 180)
                GL.Color3(renk1);
            else if (step < 225)
                GL.Color3(renk2);
            else if (step < 270)
                GL.Color3(renk1);
            else if (step < 315)
                GL.Color3(renk2);
            else if (step < 360)
                GL.Color3(renk1);
        }
    }
}
