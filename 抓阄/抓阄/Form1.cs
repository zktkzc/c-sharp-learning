using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 抓阄
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void texReady_TextChanged(object sender, EventArgs e)
        {
            numSel.Maximum = texReady.Lines.Length;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            texSelected.Text = ""; // 清空右侧选择的数据
            int num = (int)numSel.Value; // 要选择多少个
            string[] _Ready = texReady.Lines;
            for (int i = 0; i < num; i++)
            {
                bool isAdd = false; // 是否添加到右侧的选择框
                do
                {
                    Random _r = new Random(); // 创建一个随机数的类
                    int _sjs = _r.Next(0, _Ready.Length);
                    string _sel = _Ready[_sjs];
                    if (!_find(_sel, texSelected.Lines))
                    {
                        texSelected.AppendText(_sel + @"
");
                        isAdd = true;
                    }
                } while (!isAdd);
            }
        }

        /// <summary>
        /// 从字符串数组找某个字符串
        /// </summary>
        /// <param name="_f">要找的字符串</param>
        /// <param name="_array">从这个数组里找</param>
        /// <returns></returns>
        private bool _find(string _f, string[] _array)
        {
            foreach (string s in _array)
            {
                if (s == _f)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
