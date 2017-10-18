using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05.MDIFormSign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 显示子窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form1 f1 = new Form1();
            //f1.Show();
            Form2 f2 = new Form2();
            f2.MdiParent = this; //基于父窗体下的子窗体
            f2.Show();
            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();
            Form4 f4 = new Form4();
            f4.MdiParent = this;
            f4.Show();
        }

        private void 横向排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);//横向排列
        }

        private void 纵向排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);//纵向排列
        }
    }
}
