using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Ntp2_Odev_Oyun
{
    public partial class Form1 : Form
    {
        static int toplam = 0;
        Random rnd = new Random();

        static int totalTime = 10;

        public Form1()
        {
            InitializeComponent();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            Button button1 = new Button();

            button1.Size = new Size(50, 50);
            button1.Location = new Point(rnd.Next(10,590), rnd.Next(10,380));
            button1.Text = rnd.Next(-100,100).ToString();
            button1.Click += button1_Click;

            GamePanel.Controls.Add(button1);

            //this.Controls.Add(button1);

            totalTime--;
            TimeLabel.Text = totalTime.ToString();

            if (totalTime == 0)
            {
                GameOver();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button1 = (Button)sender;
            button1.Dispose();

            toplam += int.Parse(button1.Text);

            if (toplam <= 0)
            {
                GameOver();
                return;
            }

            PointLabel.Text = toplam.ToString();
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer.Start();
        }

        private void GameOver()
        {
            ButtonsPanel.Visible = false;
            GamePanel.Visible = false;
            GameOverPanel.Visible = true;

            //Button skorkaydet = new Button();
            //skorkaydet.Size = new Size(100, 200);
            //skorkaydet.Text = "Skoru Kaydet";
            //this.Controls.Add(skorkaydet);
            //FileStream fs = File.Create(@"C:\Users\AMD\source\repos\Ntp2_Odev_Oyun\SKOR.txt"); //burada skoru kaydetceğimiz txt dosyasının konumunu belirledik ve IO referans aldık
            //DateTime tarih = Directory.GetCreationTime("skor");
            //MessageBox.Show(tarih.ToString());B
        }

        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RestartButton_CLick(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Yazdirilacak
            string toWrite = "Score : " + toplam.ToString() + " Time : " + DateTime.Now;

            //Dosya konumu
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Scores.txt";

            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            File.AppendAllText(filePath, Environment.NewLine + toWrite);
        }
    }
}
