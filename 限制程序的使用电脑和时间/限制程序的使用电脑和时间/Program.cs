using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace 限制程序的使用电脑和时间
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool regOk = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists("Setup.xml"))
            {
                // 读取xml配置文件
                XmlDocument doc = new XmlDocument();
                doc.Load("Setup.xml");
                XmlNode xn = doc.SelectSingleNode("Setup/Reg");
                string _reg = xn.InnerText;
                string strReg = PubClass.ToDecrypt(PubClass.strKey, _reg);
                string[] ss = strReg.Split('|');
                if (ss.Length != 2)
                {
                    MessageBox.Show("注册码不正确！");
                }
                else if (ss[0] != PubClass.GetCpuid())
                {
                    MessageBox.Show("请在授权的电脑上使用！");
                }
                else if (DateTime.Parse(ss[1]) < DateTime.Now)
                {
                    MessageBox.Show("授权码已到期，请重新获取授权码！");
                }
                else
                {
                    regOk = true;
                }
            }
            if (regOk)
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Run(new Reg());
            }
        }
    }
}
