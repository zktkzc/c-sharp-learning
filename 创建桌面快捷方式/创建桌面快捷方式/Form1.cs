using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 创建桌面快捷方式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 获取桌面文件夹目录
            string desktopPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
            // 获取当前运行的程序
            string strExeFileName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";
            // 获取当前程序启动所在的文件夹
            string startPath = Application.StartupPath + "\\";
            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(desktopPath + "\\测试快捷方式.lnk");
            shortcut.TargetPath = startPath + strExeFileName;
            shortcut.Arguments = ""; // 传入的参数
            shortcut.WorkingDirectory = startPath; // 指定工作目录
            shortcut.IconLocation = startPath + strExeFileName + ",0"; // 图标
            shortcut.Hotkey = "CTRL+SHIFT+M"; // 热键
            shortcut.WindowStyle = 1; // 窗口样式
            MessageBox.Show("创建快捷方式成功！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 获取桌面文件夹目录
            string desktopPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
            // 获取当前运行的程序
            string strExeFileName = @"带参数的程序.exe";
            // 获取当前程序启动所在的文件夹
            string startPath = @"E:\Project\C\C#\C#学习\编写带参数的程序\编写带参数的程序\bin\Debug\";
            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(desktopPath + "\\带参数的程序快捷方式.lnk");
            shortcut.TargetPath = startPath + strExeFileName;
            shortcut.Arguments = "第一个参数 第二个参数"; // 传入的参数
            shortcut.WorkingDirectory = startPath; // 指定工作目录
            shortcut.IconLocation = startPath + strExeFileName + ",0"; // 图标
            // shortcut.Hotkey = "CTRL+SHIFT+M"; // 热键
            shortcut.WindowStyle = 1; // 窗口样式
            MessageBox.Show("创建快捷方式成功！");
        }
    }
}
