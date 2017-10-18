using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04.RadioMultiSelect
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            username_input.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //username_input.Focus();
        }

        private void StyleSB_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        private void ReSet_Click(object sender, EventArgs e)
        {
            username_input.Text = "";
            password_input.Text = "";
            username_input.Focus();
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            string user = username_input.Text;
            string pass = password_input.Text;
            string userstudent = "student";
            string userteacher = "teacher";
            string passstudent = "student";
            string passteacher = "teacher";
            if (user == userstudent && pass == passstudent && Student_radio.Checked)
            {
                MessageBox.Show("学生登录成功!!");
                return;
            }
            
            if (user == userteacher && pass == passteacher && Teacher_radio.Checked)
            {
                MessageBox.Show("老师登录成功!!");
                return;
            }
            else
            {
                MessageBox.Show("登录失败!!");
                username_input.Text = "";
                password_input.Text = "";
                username_input.Focus();
            }
            
        }

        private void OKbtn_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.Clear(Color ;);
        }
    }
}
