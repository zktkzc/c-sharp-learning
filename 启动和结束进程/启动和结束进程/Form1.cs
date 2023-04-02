using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace 启动和结束进程
{
    public partial class Form1 : Form
    {
        DataTable tbProcess = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        // 启动进程
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("请输入要启动的进程！");
                return;
            }
            try
            {
                Process.Start(textBox1.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("进程启动失败！提示：" + ex.Message);
            }
        }

        // 显示所有进程
        private void button2_Click(object sender, EventArgs e)
        {
            tbProcess.Columns.Add("Id", typeof(Int64));
            tbProcess.Columns.Add("ProcessName", typeof(string));
            foreach (Process p in Process.GetProcesses())
            {
                DataRow r = tbProcess.NewRow();
                r["Id"] = p.Id;
                r["ProcessName"] = p.ProcessName.ToString();
                tbProcess.Rows.Add(r);
            }
            dataGridView1.DataSource = tbProcess;
            dataGridView1.Columns["Id"].HeaderText = "进程ID";
            dataGridView1.Columns["ProcessName"].HeaderText = "进程名称";
            dataGridView1.Columns["ProcessName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        // 结束进程
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("请选择要结束的进程！");
                return;
            }
            killProcess((int)dataGridView1.CurrentRow.Cells["Id"].Value);
        }

        static void killProcess(int ProcessId)
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (p.Id == ProcessId)
                {
                    try
                    {
                        p.Kill();
                        p.WaitForExit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("结束进程失败！提示：" + ex.Message);
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            tbProcess.DefaultView.RowFilter = string.Format(@"ProcessName like '%{0}%'", textBox2.Text.Trim());
        }
    }
}