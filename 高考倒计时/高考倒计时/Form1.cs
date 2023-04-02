using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 高考倒计时
{
    public partial class Form1 : Form
    {

        private DateTime endTime = DateTime.Parse("2023-06-07 09:00");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime _now = DateTime.Now;
            TimeSpan ts = _now.Subtract(endTime).Duration();
            labDay.Text = ts.TotalDays.ToString();
            labHour.Text = ts.Hours.ToString().PadLeft(2, '0');
            labMin.Text = ts.Minutes.ToString().PadLeft(2, '0');
            labSec.Text = ts.Seconds.ToString().PadLeft(2, '0');
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }
    }
}
