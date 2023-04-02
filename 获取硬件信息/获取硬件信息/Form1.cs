using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 获取硬件信息
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            texMACAddr.Text = GetMACString();
            texCPUSn.Text = GetCpuid();
            texDiskSn.Text = GetDiskSerialNumber();
            texBoardSn.Text = GetBoardId();
        }

        // 获取本机的MAC地址
        private string GetMACString()
        {
            ManagementClass mAdapter = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection mo = mAdapter.GetInstances();
            foreach (ManagementBaseObject m in mo)
            {
                if ((bool)m["IpEnabled"] == true)
                {
                    return m["MacAddress"].ToString();
                }
            }
            mo.Dispose();
            return "";// null;
        }

        // 获得CPU编号
        public string GetCpuid()
        {
            var cpuid = string.Empty;
            var mc = new ManagementClass("Win32_Processor");
            var moc = mc.GetInstances();
            foreach (var o in moc)
            {
                var mo = (ManagementObject)o;
                cpuid = mo.Properties["ProcessorId"].Value.ToString();
            }
            return cpuid;
        }

        // 获取硬盘序列号
        public string GetDiskSerialNumber()
        {
            //这种模式在插入一个U盘后可能会有不同的结果，如插入我的手机时
            var hDid = string.Empty;
            var mc = new ManagementClass("Win32_DiskDrive");
            var moc = mc.GetInstances();
            foreach (var o in moc)
            {
                var mo = (ManagementObject)o;
                hDid = (string)mo.Properties["Model"].Value;
                //这名话解决有多个物理盘时产生的问题，只取第一个物理硬盘
                break;
            }
            return hDid;
        }

        // 主板编号
        public string GetBoardId()
        {
            var st = string.Empty;
            var mos = new ManagementObjectSearcher("Select * from Win32_BaseBoard");
            foreach (var o in mos.Get())
            {
                var mo = (ManagementObject)o;
                st = mo["SerialNumber"].ToString();
            }
            return st;
        }
    }
}
