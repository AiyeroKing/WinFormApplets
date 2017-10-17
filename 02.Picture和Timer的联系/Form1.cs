using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02.Picture和Timer的联系
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        string[] path = Directory.GetFiles(@"C:\Users\Aiyero\Pictures\Camera Roll");
        int i = 0;
        Random r = new Random();
        
        private void Form1_Load(object sender, EventArgs e)
        {

            string pax = "C:\\Users\\Aiyero\\Pictures\\Camera Roll\\desktop.ini";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            //在窗体加载的时候，给每一个PictureBox都赋值一张图片的路径
            i = path[i] != pax ? i : i + 1;
            pictureBox1.Image = Image.FromFile(path[i]);
            pictureBox2.Image = Image.FromFile(path[i]);
            pictureBox3.Image = Image.FromFile(path[i]);
            pictureBox4.Image = Image.FromFile(path[i]);
            pictureBox5.Image = Image.FromFile(path[i]);
            pictureBox6.Image = Image.FromFile(path[i]);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //每隔一秒钟换一张图片
            i = i + 1;
            if (i > path.Length - 1)
            {
                i = 0;
            }
            string pax = "C:\\Users\\Aiyero\\Pictures\\Camera Roll\\desktop.ini";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            //在窗体加载的时候，给每一个PictureBox都赋值一张图片的路径
            i = path[i] != pax ? i : i + 1;
            pictureBox1.Image = Image.FromFile(path[r.Next(2,path.Length)]);
            pictureBox2.Image = Image.FromFile(path[r.Next(2, path.Length)]);
            pictureBox3.Image = Image.FromFile(path[r.Next(2, path.Length)]);
            pictureBox4.Image = Image.FromFile(path[r.Next(2, path.Length)]);
            pictureBox5.Image = Image.FromFile(path[r.Next(2, path.Length)]);
            pictureBox6.Image = Image.FromFile(path[r.Next(2, path.Length)]);



        }
    }
}
