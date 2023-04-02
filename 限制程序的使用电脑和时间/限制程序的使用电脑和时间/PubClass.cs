using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 限制程序的使用电脑和时间
{
    internal class PubClass
    {
        public static string strKey = "tkzc";

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="_s">要加密的字符串</param>
        /// <returns>返回加密后的字符串</returns>
        public static string myMD5(string _s)
        {
            MD5 _md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(_s);
            byte[] myBytes = _md5.ComputeHash(fromData);
            string bytesToString = "";
            for (int i = 0; i < myBytes.Length; i++)
            {
                bytesToString += myBytes[i].ToString("x2");
            }
            return bytesToString;
        }

        /// <summary>
        /// 加密函数
        /// </summary>
        /// <param name="encryptKey">加密密钥</param>
        /// <param name="str">需要加密字符串</param>
        /// <returns>加密后的字符串</returns>
        /// <exception cref="Exception"></exception>
        public static string ToEncrypt(string encryptKey, string str)
        {
            try
            {
                //将密钥字符串转换为字节序列
                byte[] P_byte_key = Encoding.Unicode.GetBytes(encryptKey);
                //将字符串转换为字节序列
                byte[] P_byte_data = Encoding.Unicode.GetBytes(str);
                //创建内存流对象
                MemoryStream P_Stream_MS = new MemoryStream();
                {
                    using (CryptoStream P_CryptStream_Stream = new CryptoStream(P_Stream_MS, new DESCryptoServiceProvider().CreateEncryptor(P_byte_key, P_byte_key), CryptoStreamMode.Write))
                    {
                        P_CryptStream_Stream.Write(P_byte_data, 0, P_byte_data.Length);//向加密流中写入字节序列
                        P_CryptStream_Stream.FlushFinalBlock();//将数据压入基础流
                        byte[] P_bt_temp = P_Stream_MS.ToArray();//从内存流中获取字节序列
                        return Convert.ToBase64String(P_bt_temp);
                    }
                }

            }
            catch (CryptographicException ce)
            {
                throw new Exception(ce.Message);
            }
        }

        /// <summary>
        /// 解密函数
        /// </summary>
        /// <param name="encryptKey">解密函数</param>
        /// <param name="str">需要解密的字符串</param>
        /// <returns>解密后的字符串</returns>
        /// <exception cref="Exception"></exception>
        public static string ToDecrypt(string encryptKey, string str)
        {
            try
            {
                //将密钥字符串转换为字节序列
                byte[] P_byte_key = Encoding.Unicode.GetBytes(encryptKey);
                //将加密后的字符串转换为字节序列
                byte[] P_byte_data = Convert.FromBase64String(str);
                //创建内存流对象并写入数据
                MemoryStream P_Stream_MS = new MemoryStream(P_byte_data);
                //创建加密流对象
                CryptoStream P_CryptStream_Stream = new CryptoStream(P_Stream_MS, new DESCryptoServiceProvider().CreateDecryptor(P_byte_key, P_byte_key), CryptoStreamMode.Read);
                byte[] P_bt_temp = new byte[200];//创建字节序列对象
                //创建内存流对象
                MemoryStream P_MemoryStream_temp = new MemoryStream();
                int i = 0;//创建记数器
                while ((i = P_CryptStream_Stream.Read(//使用while循环得到解密数据
                    P_bt_temp, 0, P_bt_temp.Length)) > 0)
                {
                    P_MemoryStream_temp.Write(//将解密后的数据放入内存流
                        P_bt_temp, 0, i);
                }
                return //方法返回解密后的字符串
                    Encoding.Unicode.GetString(P_MemoryStream_temp.ToArray());
            }
            catch (CryptographicException ce)
            {
                throw new Exception(ce.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("解密失败，提示：" + ex.Message);
                return "";
            }
        }

        // 获得CPU编号
        public static string GetCpuid()
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
    }
}
