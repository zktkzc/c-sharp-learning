using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace 调用浏览器打开网页
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 创建数据表
            DataTable tbUrl = new DataTable();
            tbUrl.Columns.Add("Id", typeof(int));
            tbUrl.Columns.Add("Name", typeof(string));
            tbUrl.Columns.Add("Url", typeof(string));

            // 新建行
            DataRow r1 = tbUrl.NewRow();
            r1["Id"] = 1;
            r1["Name"] = "百度";
            r1["Url"] = "https://www.baidu.com";
            tbUrl.Rows.Add(r1);

            DataRow r2 = tbUrl.NewRow();
            r2["Id"] = 2;
            r2["Name"] = "腾讯";
            r2["Url"] = "https://www.QQ.com";
            tbUrl.Rows.Add(r2);

            DataRow r3 = tbUrl.NewRow();
            r3["Id"] = 3;
            r3["Name"] = "记事本";
            r3["Url"] = "notepad.exe";
            tbUrl.Rows.Add(r3);

            DataRow r4 = tbUrl.NewRow();
            r4["Id"] = 4;
            r4["Name"] = "计算器";
            r4["Url"] = "calc.exe";
            tbUrl.Rows.Add(r4);

            dataURL.DataSource = tbUrl;
            dataURL.Columns["Id"].HeaderText = "序号";
            dataURL.Columns["Name"].HeaderText = "名称";
            dataURL.Columns["Url"].HeaderText = "网址";
            dataURL.Columns["Url"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }

        private void dataURL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataURL.Columns[e.ColumnIndex].Name == "Url")
            {
                string url = dataURL[e.ColumnIndex, e.RowIndex].Value.ToString().Trim();
                if (url.EndsWith(".exe"))
                {
                    Process.Start(url);
                }
                else
                {
                    Process.Start("chrome.exe", url);
                }
            }
        }
    }
}
