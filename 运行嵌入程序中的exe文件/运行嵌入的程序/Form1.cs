using System;
using System.Windows.Forms;
using 运行嵌入的程序.Properties;

namespace 运行嵌入的程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = RunExe.RunExeRes(Resources.运行嵌入程序中的exe文件);
            if (s != "OK")
            {
                MessageBox.Show(s);
            }
        }
    }
}
