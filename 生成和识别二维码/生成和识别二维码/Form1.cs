using System;
using System.Drawing;
using System.Windows.Forms;
using com.google.zxing;
using com.google.zxing.common;

namespace 生成和识别二维码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="sContent">内容</param>
        /// <param name="iWidth">宽度</param>
        /// <param name="iHeight">高度</param>
        /// <returns>返回生成的二维码图片</returns>
        public static Bitmap GetBitmap(string sContent, int iWidth, int iHeight)
        {
            string _message = sContent;
            ByteMatrix byteMatrix = new MultiFormatWriter().encode(_message, BarcodeFormat.QR_CODE, iWidth, iHeight);
            int _width = byteMatrix.Width;
            int _height = byteMatrix.Height;
            Bitmap bmap = new Bitmap(_width, _height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    bmap.SetPixel(i, j, byteMatrix.get_Renamed(i, j) != -1 ? ColorTranslator.FromHtml("0xff000000") : ColorTranslator.FromHtml("0xffffffff"));
                }
            }
            return bmap;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            pictureBox1.Image = GetBitmap(textBox1.Text, pictureBox1.Width, pictureBox1.Height);
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            pictureBox1.Image.Save(@"./test.jpg");
        }

        private void btnRead_Click(object sender, System.EventArgs e)
        {
            Image _img = Image.FromFile(@"./test.jpg");
            string s = QrcodeToText((Bitmap)_img);
            textBox2.Text = s;
        }

        /// <summary>
        /// 识别二维码
        /// </summary>
        /// <param name="bitmap">需要识别的二维码</param>
        /// <returns>识别出的二维码内容</returns>
        public static string QrcodeToText(Bitmap bitmap)
        {
            LuminanceSource source = new RGBLuminanceSource(bitmap, bitmap.Width, bitmap.Height);
            BinaryBitmap binaryBitmap = new BinaryBitmap(new HybridBinarizer(source));
            try
            {
                Result result = new MultiFormatReader().decode(binaryBitmap);
                return result.Text;
            }
            catch (Exception ex)
            {
                return string.Format("识别二维码出错！\r\n\r\n提示：{0}", ex.Message);
            }
        }
    }
}
