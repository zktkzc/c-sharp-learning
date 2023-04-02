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

namespace Command命令执行对象
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
    }
}
