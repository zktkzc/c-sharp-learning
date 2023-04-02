using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace 导出数据到Excel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string strConn = @"Server=127.0.0.1;User Id=sa;Pwd=123456;DataBase=Test;";
            SqlConnection myConn = new SqlConnection(strConn);
            SqlDataAdapter myDa = new SqlDataAdapter("select * from Student", myConn);
            DataSet ds = new DataSet();
            myDa.Fill(ds, "Student");
            DataTable dt = ds.Tables["Student"];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Code"].HeaderText = "编号";
            dataGridView1.Columns["Name"].HeaderText = "姓名";
            dataGridView1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Age"].HeaderText = "年龄";
            labRowCount.Text = "总行数：" + dataGridView1.RowCount.ToString();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.Cells["Name"].Value = r.Cells["Name"].Value.ToString().Trim();
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                labCurCell.Text = "当前选择：" + dataGridView1.CurrentCell.Value.ToString();
                labCurRow.Text = "当前行：" + (dataGridView1.CurrentCell.RowIndex + 1).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRead_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application xlApp = new Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("无法创建Excel对象，可能您的计算机未安装Excel！");
                    return;
                }
                Excel.Workbooks workbooks = xlApp.Workbooks;
                Excel.Workbook workbook = workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];
                // 写入列标题
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // 写入数值
                for (int r = 0; r < dataGridView1.Rows.Count; r++)
                {
                    for (int c = 0; c < dataGridView1.Columns.Count; c++)
                    {
                        if (dataGridView1[c, r].Value != null)
                        {
                            worksheet.Cells[r + 2, c + 1] = dataGridView1[c, r].Value;
                        }
                    }
                }
                worksheet.Columns.EntireColumn.AutoFit(); // 列宽自适应
                                                          // 隐藏不可见的列
                for (int c = 0; c < dataGridView1.Columns.Count; c++)
                {
                    ((Excel.Range)worksheet.Cells[1, c + 1]).EntireColumn.Hidden = true;
                }
                worksheet.PageSetup.PrintGridlines = true; // 打印网格线
                worksheet.PageSetup.CenterHeader = "&16" + "学生名单";
                worksheet.PageSetup.RightFooter = "第&P页 共&N页";
                worksheet.PageSetup.CenterHorizontally = true; // 水平居中
                worksheet.PageSetup.PrintTitleRows = "$1:$1"; // 首页标题行
                workbook.SaveCopyAs(@"./学生成绩.xls");
                xlApp.Quit();
                MessageBox.Show("导出成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("创建Excel对象出错，提示：" + ex.Message);
                return;
            }
        }
    }
}
