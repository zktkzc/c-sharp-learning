using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 身份证号批量校验
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPaster_Click(object sender, EventArgs e)
        {
            texIdCard.Text = Clipboard.GetText();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            texIdCard.Text = "";
        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            if (texIdCard.Text == "")
            {
                MessageBox.Show("请先粘贴要校验的身份证号到左侧的文本框中（每行一个）！");
                return;
            }

            int num = texIdCard.Lines.Length;
            ProgressBar1.Maximum = num;
            ProgressBar1.Value = 0;
            ProgressBar1.Visible = true;
            texResult.Text = "";
            string _s = labMessage.Text;
            for (int i = 0; i < num; i++)
            {
                labMessage.Text = string.Format("正在校验第 {0}/{1} 个身份证号......", i + 1, num);
                ProgressBar1.Value++;
                Application.DoEvents(); // 刷新屏幕
                string _c = texIdCard.Lines[i].Trim();
                if (_c == "")
                {
                    continue;
                }

                if (_c.Length != 18)
                {
                    texResult.AppendText(string.Format(@"第{0}个身份证号不是18位：{1}
", i + 1, _c));
                    continue;
                }

                if (!CardIdValid.CheckIdCard(_c))
                {
                    texResult.AppendText(string.Format(@"第{0}个身份证号校验失败：{1}
", i + 1, _c));
                }
            }

            labMessage.Text = _s;
            ProgressBar1.Value = 0;
            ProgressBar1.Visible = false;
            MessageBox.Show("校验完成！" + (texResult.Text.Trim() == "" ? "" : " 校验结果已显示于右侧文本框。"));
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (texResult.Text.Trim() == "")
            {
                MessageBox.Show("没有可以复制的内容！");
            }
            else
            {
                Clipboard.SetText(texResult.Text.Trim());
                MessageBox.Show("校验结果已复制到剪切板！");
            }
        }
    }
}
