using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;
using Captura;
using System.IO;

namespace RecordBook
{
    public partial class Form1 : Form
    {
        public bool isStarted = false;
        public Thread t;
        public Recorder rec;
        public string outputPath;
        public int kalite = 80;
        public int width = 1920;
        public int height = 1080;


        public Form1()
        {
            InitializeComponent();
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            kaydetButton.ForeColor = Color.Red;
            outputPath = yolTextBox.Text;
            kalite = Convert.ToInt32(kaliteNumericUpDown.Value);
            width = Convert.ToInt32(genislikNumericUpDown.Value);
            height = Convert.ToInt32(yukseklikNumericUpDown.Value);

            rec = new Recorder(new RecorderParams(outputPath, 10, SharpAvi.KnownFourCCs.Codecs.MotionJpeg, kalite, width, height));
            isStarted = true;
            t = new Thread(StartRecording);
            t.Start();
        }

        public void StartRecording()
        {
            while (isStarted)
            {
                TakeScreenShot();
                Thread.Sleep(50);
                
            }
        }

        public void TakeScreenShot()
        {

            //Bitmap captureBitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            // 1920x1080 ekranda 1536x864 gösteriyor
            Bitmap captureBitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            Rectangle captureRectangle = new Rectangle(0,0,width, height); //Screen.AllScreens[0].Bounds;
            Graphics captureGraphics = Graphics.FromImage(captureBitmap);
            captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
            //string filename = @"D:\Tests\Capture" + DateTime.Now.ToString("HH_mm_ss_ff") + ".jpg";
            //captureBitmap.Save(filename, ImageFormat.Jpeg);
            pictureBox1.Image = captureBitmap;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //rec.Dispose();
            durdurButton_Click(null, EventArgs.Empty);
            if (isStarted)
            {
                isStarted = false;
                t.Abort();
            }
            Application.Exit();
        }

        private void durdurButton_Click(object sender, EventArgs e)
        {
            if (isStarted)
            {
                kaydetButton.ForeColor = Color.White;
                rec.Dispose();
                isStarted = false;
                t.Abort();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            kaydetButton.MouseEnter += OnMouseEnterKaydet;
            kaydetButton.MouseLeave += OnMouseLeaveKaydet;

            durdurButton.MouseEnter += OnMouseEnterDurdur;
            durdurButton.MouseLeave += OnMouseLeaveDurdur;

            acButton.MouseEnter += OnMouseEnterAc;
            acButton.MouseLeave += OnMouseLeaveAc;

            outputPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\output.avi";
            yolTextBox.Text = outputPath;
        }

        private void OnMouseEnterKaydet(object sender, EventArgs e)
        {
            kaydetButton.ForeColor = Color.Red;
        }

        private void OnMouseLeaveKaydet(object sender, EventArgs e)
        {
            if (!isStarted) { kaydetButton.ForeColor = Color.White; }
        }

        private void OnMouseEnterDurdur(object sender, EventArgs e)
        {
            durdurButton.ForeColor = Color.Red;
        }

        private void OnMouseLeaveDurdur(object sender, EventArgs e)
        {
            if (!isStarted) { durdurButton.ForeColor = Color.White; }
        }

        private void OnMouseEnterAc(object sender, EventArgs e)
        {
            acButton.ForeColor = Color.Red;
        }

        private void OnMouseLeaveAc(object sender, EventArgs e)
        {
            acButton.ForeColor = Color.White;
        }

        private void acButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog
            {
                InitialDirectory = outputPath,
                Title = "Kaydedilecek Konumu Seç",
                DefaultExt = "avi",
                Filter = "avi Dosyaları (*.avi)|*.avi|Tüm Dosyalar(*.*)|*.*"
            };
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Kayit = new StreamWriter(save.FileName);
                Kayit.Close();
                yolTextBox.Text = save.FileName;
                outputPath = save.FileName;
            }
        }
    }
}
