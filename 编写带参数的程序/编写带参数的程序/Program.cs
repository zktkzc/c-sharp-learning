using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 编写带参数的程序
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length == 0)
            {
                MessageBox.Show("没有传递参数");
            }
            else if (args.Length == 1)
            {
                Application.Run(new Form1(args));
            }
            else if (args.Length == 2)
            {
                Application.Run(new Form2(args));
            }
        }
    }
}
