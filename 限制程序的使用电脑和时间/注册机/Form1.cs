using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 注册机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string strCode = texMachineCode.Text.Trim(), strDate = dateMax.Value.ToString("yyyy-MM-dd");
            texRegCode.Text = PubClass.ToEncrypt(PubClass.strKey, strCode + "|" + strDate);
        }
    }
}
