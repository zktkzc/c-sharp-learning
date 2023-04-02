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

namespace 读取和保存配置到XML文件
{
    public partial class ConnSetup : Form
    {
        public ConnSetup()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string _conn = string.Format(@"Server={0};User Id={1};Pwd={2};DataBase={3};", texServer.Text.Trim(), texUserName.Text.Trim(), texPwd.Text.Trim(), texDatabase.Text.Trim());
            _conn = PubClass.ToEncrypt(PubClass.strKey, _conn);
            XmlDocument doc = new XmlDocument();
            // 添加描述信息
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            // 创建根节点
            XmlElement _setup = doc.CreateElement("Setup");
            doc.AppendChild(_setup);
            // 给根节点Setup创建一个子节点
            XmlElement conn = doc.CreateElement("Conn");
            conn.InnerText = _conn;
            _setup.AppendChild(conn);
            doc.Save("Setup.xml");
            MessageBox.Show("保存配置文件成功！");
            this.Close();
        }
    }
}
