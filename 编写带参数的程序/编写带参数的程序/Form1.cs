using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 编写带参数的程序
{
    public partial class Form1 : Form
    {
        string[] _args;
        public Form1(string[] args)
        {
            InitializeComponent();
            _args = args;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (_args.Length == 1)
            {
                textBox1.Text = string.Format(@"传递的参数为：{0}", _args[0]);
            }
        }
    }
}
