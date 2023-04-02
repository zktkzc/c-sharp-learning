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
    public partial class Form1 : Form
    {
        string strRemark = ""; // 保存输入的值

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(strRemark);
            form2.ShowDialog();
            if (form2.isOk)
            {
                strRemark = form2.textBox1.Text;
                label1.Text = string.Format(@"输入的内容: {0}", strRemark);
            }
            else
            {
                label1.Text = "输入的内容：";
            }
        }
    }
}
