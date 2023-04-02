using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace 清空回收站
{
    public partial class Form1 : Form
    {

        const int SHERB_NOCONFIRMATION = 0x000001; // 清空时不显示确认对话框
        const int SHERB_NOPROGRESSUI = 0x000002; // 不显示进度条
        const int SHERB_NOSOUND = 0x000004; // 删除完毕不播放声音

        [DllImportAttribute("shell32.dll")]
        private static extern int SHEmptyRecycleBin(IntPtr handle, string root, int flags);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SHEmptyRecycleBin(this.Handle, "", SHERB_NOCONFIRMATION + SHERB_NOPROGRESSUI + SHERB_NOSOUND);
        }
    }
}
