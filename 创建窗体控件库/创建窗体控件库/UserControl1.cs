using System.ComponentModel;
using System.Windows.Forms;

namespace 创建窗体控件库
{
    public partial class UserControl1 : UserControl
    {
        string userName = "";

        public UserControl1()
        {
            InitializeComponent();
        }

        [
            Browsable(true),
            Description("显示的姓名"),
            Category("Appearance"),
            DefaultValue(typeof(string), "张三")
        ]
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
                label1.Text = string.Format(@"姓名：{0}", userName);
            }
        }
    }
}
