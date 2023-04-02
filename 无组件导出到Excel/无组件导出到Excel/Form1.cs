using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace 无组件导出到Excel
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
            StreamWriter sw = new StreamWriter(@"./学生成绩.xls", false, Encoding.GetEncoding("gb2312"));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                sb.Append(dataGridView1.Columns[i].HeaderText.ToString() + "\t");
            }
            sb.Append(Environment.NewLine);
            for (int r = 0; r < dataGridView1.Rows.Count; r++)
            {
                for (int c = 0; c < dataGridView1.Columns.Count; c++)
                {
                    sb.Append(dataGridView1[c, r].Value.ToString() + "\t");
                }
                sb.Append(Environment.NewLine);
            }
            sw.Write(sb.ToString());
            sw.Flush();
            sw.Close();
            MessageBox.Show("导出成功！");
        }
    }
}
