using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 体重指数_BMI_计算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal _Height = numHeight.Value;
            decimal _Weight = numWeight.Value;
            bool isMan = radMan.Checked; // True——男 False——女

            if (_Height == 0 || _Height == 0)
            {
                MessageBox.Show("体重和身高不可以为0!");
                return;
            }
            decimal _BMI = Math.Round(_Weight / (_Height * _Height), 2); // 保留两位小数
            texBMI.Text = _BMI.ToString();
            if (isMan)
            {
                // 男性
                if (_BMI < 20)
                {
                    texDes.Text = "过轻";
                }

                if (_BMI >= 20 && _BMI < 25)
                {
                    texDes.Text = "适中";
                }

                if (_BMI >= 25 && _BMI < 30)
                {
                    texDes.Text = "过重";
                }

                if (_BMI >= 30 && _BMI < 35)
                {
                    texDes.Text = "肥胖";
                }
                else if (_BMI > 35)
                {
                    texDes.Text = "非常肥胖";
                }
            }
            else
            {
                // 女性
                if (_BMI < 19)
                {
                    texDes.Text = "过轻";
                }

                if (_BMI >= 19 && _BMI < 25)
                {
                    texDes.Text = "适中";
                }

                if (_BMI >= 25 && _BMI < 29)
                {
                    texDes.Text = "过重";
                }

                if (_BMI >= 29 && _BMI < 34)
                {
                    texDes.Text = "肥胖";
                }
                else if (_BMI > 34)
                {
                    texDes.Text = "非常肥胖";
                }
            }
        }
    }
}
