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

namespace _01.PitcureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Aiyero\Pictures\Camera Roll\html.jpg");
            //获得指定文件夹的所有文件的全路径
           
        }

       string[] path = Directory.GetFiles(@"C:\Users\Aiyero\Pictures\Camera Roll");
       int i = 0;
        //下一张按钮
        private void down_Next_picture_btn_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            string pax = "C:\\Users\\Aiyero\\Pictures\\Camera Roll\\desktop.ini";
            if (path[i] == pax)
            {
                i++;
            }
            pictureBox1.Image = Image.FromFile(path[i]);
            i++;
            if(i == path.Length-1)
            {
                i = 0;
            }
        }
        //上一张按钮
        private void up_Next_picture_btn_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            string pax = "C:\\Users\\Aiyero\\Pictures\\Camera Roll\\desktop.ini";
            if (path[i] == pax)
            {
                i--;
            }
            pictureBox1.Image = Image.FromFile(path[i]);
            i--;

            i = i == -1 ? path.Length - 1 : i;
            //if (i ==-1)
            //{
            //    i = path.Length-1;
            //}
        }
    }
}
