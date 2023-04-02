using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace 读取和保存配置到XML文件
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!File.Exists("Setup.xml"))
            {
                // 没有找到配置文件
                Application.Run(new ConnSetup());
            }
            if (File.Exists("Setup.xml"))
            {
                // 读取xml配置文件
                XmlDocument doc = new XmlDocument();
                doc.Load("Setup.xml");
                XmlNode xn = doc.SelectSingleNode("Setup/Conn");
                string _Conn = xn.InnerText;
                PubClass.strConn = PubClass.ToDecrypt(PubClass.strKey, _Conn);
                Application.Run(new Login());
                if (PubClass.isLogin)
                {
                    Application.Run(new Main());
                }
            }
        }
    }
}
