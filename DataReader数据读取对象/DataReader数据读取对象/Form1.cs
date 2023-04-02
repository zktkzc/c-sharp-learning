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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace DataReader数据读取对象
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strCode = texCode.Text, strName = texName.Text, strAge = texAge.Text;
            string strConn = @"Server=192.168.56.1;User Id=sa;Pwd=123456;DataBase=Test;";
            SqlConnection sqlConnection = new SqlConnection(strConn);
            sqlConnection.Open();
            SqlCommand myCmd = new SqlCommand();
            myCmd.Connection = sqlConnection;
            myCmd.Parameters.Add(new SqlParameter("@Code", strCode));
            myCmd.Parameters.Add(new SqlParameter("@Name", strName));
            myCmd.Parameters.Add(new SqlParameter("@Age", strAge));
            myCmd.CommandText = @"insert into Student(Code,Name,Age) values(@Code,@Name,@Age)";
            int res = myCmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show(string.Format(@"成功插入{0}行记录！", res.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strConn = @"Server=192.168.56.1;User Id=sa;Pwd=123456;DataBase=Test;";
            SqlConnection sqlConnection = new SqlConnection(strConn);
            sqlConnection.Open();
            SqlCommand myCmd = new SqlCommand();
            myCmd.Connection = sqlConnection;
            myCmd.CommandText = @"select * from Student";
            SqlDataReader myRead = myCmd.ExecuteReader();
            if (!myRead.HasRows)
            {
                MessageBox.Show("没有检索到数据！！！");
            }
            else
            {
                while (myRead.Read())
                {
                    textBox1.AppendText(string.Format("编号：{0}，姓名：{1}，年龄：{2}\r\n", myRead["Code"].ToString().Trim(), myRead["Name"].ToString().Trim(), myRead["Age"]));
                }
            }
            myRead.Close();
            sqlConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string _Code = txtCode1.Text.Trim();
            if (_Code == "")
            {
                MessageBox.Show("编号不能为空！！！");
                return;
            }
            string strConn = @"Server=192.168.56.1;User Id=sa;Pwd=123456;DataBase=Test;";
            SqlConnection sqlConnection = new SqlConnection(strConn);
            sqlConnection.Open();
            SqlCommand myCmd = new SqlCommand();
            myCmd.Connection = sqlConnection;
            myCmd.CommandText = @"select * from Student where Code=@Code";
            myCmd.Parameters.Add(new SqlParameter("@Code", _Code));
            SqlDataReader myRead = myCmd.ExecuteReader();
            if (!myRead.HasRows)
            {
                MessageBox.Show(string.Format("没有找到编号为{0}的数据！！！", _Code));
            }
            else
            {
                if (myRead.Read())
                {
                    txtName1.Text = myRead["Name"].ToString().Trim();
                    txtAge1.Text = myRead["Age"].ToString();
                }
            }
            myRead.Close();
            sqlConnection.Close();
        }
    }
}
