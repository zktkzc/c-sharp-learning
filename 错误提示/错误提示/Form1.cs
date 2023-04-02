using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 错误提示
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text != "admin")
            {
                errorProvider1.SetError(textBox1, "用户名错误！");
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }

            if (textBox2.Text != "123456")
            {
                errorProvider1.SetError(textBox2, "密码错误！");
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
            }
        }
    }
}
