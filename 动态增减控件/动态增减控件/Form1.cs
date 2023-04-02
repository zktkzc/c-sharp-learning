using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 动态增减控件
{
    public partial class Form1 : Form
    {

        int i = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button myBtn = new Button();
            myBtn.Text = "测试" + i.ToString();
            myBtn.Click += MyBtn_Click;
            i++;
            flowLayoutPanel1.Controls.Add(myBtn);
        }

        private void MyBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show("您点击的是：" + btn.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl1 myCon = new UserControl1();
            flowLayoutPanel1.Controls.Add(myCon);
        }
    }
}
