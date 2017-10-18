using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace _03.TextBox换行
{
    public partial class PaoMaLight : Form
    {
        public PaoMaLight()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 时间刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("你中病毒啦！哈哈");
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0,1);

            label2.Text = DateTime.Now.ToString();
        }
    }
}
