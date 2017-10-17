using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02.Picture和Timer的联系
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点啊点啊点啊点啊点啊。
        /// </summary>  
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
