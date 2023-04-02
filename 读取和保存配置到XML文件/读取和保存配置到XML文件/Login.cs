using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 读取和保存配置到XML文件
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserReg userReg = new UserReg();
            userReg.ShowDialog();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(PubClass.strConn);
            conn.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = conn;
            myCommand.Parameters.Add(new SqlParameter("@UserName", texUserName.Text.Trim()));
            myCommand.Parameters.Add(new SqlParameter("@UserPwd", texPwd.Text.Trim()));
            myCommand.Parameters.Add(new SqlParameter("@UserType", comType.Text.Trim()));
            myCommand.CommandText = @"select UserPwd from TUserInfo where UserName=@UserName and UserType=@UserType";
            object _pwd = myCommand.ExecuteScalar();
            if (_pwd == null)
            {
                MessageBox.Show(string.Format(@"没有找到用户名为{0}且用户类别为{1}的记录！", texUserName.Text.Trim(), comType.Text.Trim()));
            }
            if (_pwd.ToString().Trim() != PubClass.myMD5(texPwd.Text.Trim()))
            {
                MessageBox.Show("密码错误！");
                return;
            }
            else
            {
                PubClass.isLogin = true;
                this.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            comType.SelectedIndex = 0;
        }
    }
}
