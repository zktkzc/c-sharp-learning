using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 不同窗体间传递数据
{
    public partial class Form2 : Form
    {
        public bool isOk = false;
        string remark = "";

        public Form2(string strParam = "")
        {
            remark = strParam;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isOk = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            textBox1.Text = remark;
        }
    }
}
