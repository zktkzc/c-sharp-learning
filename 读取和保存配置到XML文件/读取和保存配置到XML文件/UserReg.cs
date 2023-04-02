using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 读取和保存配置到XML文件
{
    public partial class UserReg : Form
    {
        public UserReg()
        {
            InitializeComponent();
        }

        private void UserReg_Load(object sender, EventArgs e)
        {
            comType.SelectedIndex = 0;
            for (int i = 1950; i < 2050; i++)
            {
                comYear.Items.Add(i.ToString());
            }
            comYear.Text = DateTime.Now.Year.ToString();

            for (int i = 1; i < 13; i++)
            {
                comMonth.Items.Add(i.ToString());
            }
            comMonth.SelectedIndex = 0;

            for (int i = 1; i < 32; i++)
            {
                comDay.Items.Add(i.ToString());
            }
            comDay.SelectedIndex = 0;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(PubClass.strConn);
            conn.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = conn;
            // 构建命令文本
            myCommand.CommandText = @"insert into TUserInfo(UserName,UserPwd,UserType,UserSex,UserBirthday,UserPhone,UserAddress) values(@UserName,@UserPwd,@UserType,@UserSex,@UserBirthday,@UserPhone,@UserAddress)";

            // 使用md5加密
            string pwd = PubClass.myMD5(texPwd.Text.Trim());

            // 添加参数
            myCommand.Parameters.Add(new SqlParameter("@UserName", texUserName.Text.Trim()));
            myCommand.Parameters.Add(new SqlParameter("@UserPwd", pwd));
            myCommand.Parameters.Add(new SqlParameter("@UserType", comType.Text.Trim()));
            myCommand.Parameters.Add(new SqlParameter("@UserSex", radMan.Checked ? "男" : "女"));
            myCommand.Parameters.Add(new SqlParameter("@UserBirthday", string.Format(@"{0}-{1}-{2}", comYear.Text.Trim(), comMonth.Text.Trim(), comDay.Text.Trim())));
            myCommand.Parameters.Add(new SqlParameter("@UserPhone", texPhone.Text.Trim()));
            myCommand.Parameters.Add(new SqlParameter("@UserAddress", comPrince.Text.Trim() + comCity.Text.Trim()));
            try
            {
                if (myCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("注册成功！");
                    this.Close();
                    Login login = new Login();
                    login.ShowDialog();
                }
                else
                {
                    MessageBox.Show("注册失败！");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(string.Format("注册错误，提示：{0}", ex.Message));
            }
            finally
            {
                conn.Close();
            }
        }
    }
}