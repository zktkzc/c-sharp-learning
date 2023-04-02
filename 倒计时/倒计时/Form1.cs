using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 倒计时
{
    public partial class Form1 : Form
    {
        private DateTime t = DateTime.Parse("1900-01-01");

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t = t.AddSeconds(-1);
            labTime.Text = t.ToString("mm:ss");
            if (t == DateTime.Parse("1900-01-01"))
            {
                labTime.Text = "时间到！！！";
                timer1.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            t = t.AddMinutes(double.Parse(numericUpDown1.Value.ToString()));
            timer1.Enabled = true;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
