using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace 限制程序的使用电脑和时间
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void Reg_Shown(object sender, EventArgs e)
        {
            texMachineCode.Text = PubClass.GetCpuid();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (texRegCode.Text.Trim() == "")
            {
                MessageBox.Show("请输入注册码！");
                return;
            }

            string _reg = texRegCode.Text.Trim();
            XmlDocument doc = new XmlDocument();
            // 添加描述信息
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            // 创建根节点
            XmlElement _setup = doc.CreateElement("Setup");
            doc.AppendChild(_setup);
            // 给根节点Setup创建一个子节点
            XmlElement reg = doc.CreateElement("Reg");
            reg.InnerText = _reg;
            _setup.AppendChild(reg);
            doc.Save("Setup.xml");
            MessageBox.Show("保存配置文件成功，请重新启动程序以验证是否注册成功！");
            this.Close();
        }
    }
}
