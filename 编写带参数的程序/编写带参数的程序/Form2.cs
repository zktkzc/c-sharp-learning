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
    public partial class Form2 : Form
    {
        string[] _args;
        public Form2(string[] args)
        {
            InitializeComponent();
            _args = args;
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            if (_args.Length == 2)
            {
                textBox1.Text = string.Format(@"第一个参数：{0}，第二个参数：{1}", _args[0], _args[1]);
            }
        }
    }
}
