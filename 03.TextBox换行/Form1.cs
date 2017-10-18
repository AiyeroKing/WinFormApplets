using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03.TextBox换行
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 双击控件可弹出下方反射函数；
        /// 当文本框的内容发送改变时，将值复制给Label 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textscanf_TextChanged(object sender, EventArgs e)
        {
             textprintf.Text = textscanf.Text ;
        }
    }
}
