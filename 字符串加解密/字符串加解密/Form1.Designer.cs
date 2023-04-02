namespace 字符串加解密
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.texOrigin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.texEncKey = new System.Windows.Forms.TextBox();
            this.btnEnc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.texEnc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDec = new System.Windows.Forms.Button();
            this.texDecKey = new System.Windows.Forms.TextBox();
            this.textDec = new System.Windows.Forms.TextBox();
            this.texEnc2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEnc);
            this.groupBox1.Controls.Add(this.texEncKey);
            this.groupBox1.Controls.Add(this.texEnc);
            this.groupBox1.Controls.Add(this.texOrigin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(583, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "字符串加密";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "加密前的字符串：";
            // 
            // texOrigin
            // 
            this.texOrigin.Location = new System.Drawing.Point(11, 51);
            this.texOrigin.Multiline = true;
            this.texOrigin.Name = "texOrigin";
            this.texOrigin.Size = new System.Drawing.Size(565, 85);
            this.texOrigin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "输入加密密钥（4位）：";
            // 
            // texEncKey
            // 
            this.texEncKey.Location = new System.Drawing.Point(141, 145);
            this.texEncKey.Name = "texEncKey";
            this.texEncKey.Size = new System.Drawing.Size(317, 23);
            this.texEncKey.TabIndex = 2;
            // 
            // btnEnc
            // 
            this.btnEnc.Location = new System.Drawing.Point(464, 145);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.Size = new System.Drawing.Size(112, 23);
            this.btnEnc.TabIndex = 3;
            this.btnEnc.Text = "加密";
            this.btnEnc.UseVisualStyleBackColor = true;
            this.btnEnc.Click += new System.EventHandler(this.btnEnc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "加密后的字符串：";
            // 
            // texEnc
            // 
            this.texEnc.Location = new System.Drawing.Point(11, 196);
            this.texEnc.Multiline = true;
            this.texEnc.Name = "texEnc";
            this.texEnc.ReadOnly = true;
            this.texEnc.Size = new System.Drawing.Size(565, 85);
            this.texEnc.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDec);
            this.groupBox2.Controls.Add(this.texDecKey);
            this.groupBox2.Controls.Add(this.textDec);
            this.groupBox2.Controls.Add(this.texEnc2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 321);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(583, 295);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "字符串解密";
            // 
            // btnDec
            // 
            this.btnDec.Location = new System.Drawing.Point(464, 145);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(112, 23);
            this.btnDec.TabIndex = 3;
            this.btnDec.Text = "解密";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // texDecKey
            // 
            this.texDecKey.Location = new System.Drawing.Point(141, 145);
            this.texDecKey.Name = "texDecKey";
            this.texDecKey.Size = new System.Drawing.Size(317, 23);
            this.texDecKey.TabIndex = 2;
            // 
            // textDec
            // 
            this.textDec.Location = new System.Drawing.Point(11, 196);
            this.textDec.Multiline = true;
            this.textDec.Name = "textDec";
            this.textDec.ReadOnly = true;
            this.textDec.Size = new System.Drawing.Size(565, 85);
            this.textDec.TabIndex = 1;
            // 
            // texEnc2
            // 
            this.texEnc2.Location = new System.Drawing.Point(11, 51);
            this.texEnc2.Multiline = true;
            this.texEnc2.Name = "texEnc2";
            this.texEnc2.Size = new System.Drawing.Size(565, 85);
            this.texEnc2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "输入解密密钥（4位）：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "解密后的字符串：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "解密前的字符串：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 632);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字符串加密和解密";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEnc;
        private System.Windows.Forms.TextBox texEncKey;
        private System.Windows.Forms.TextBox texEnc;
        private System.Windows.Forms.TextBox texOrigin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.TextBox texDecKey;
        private System.Windows.Forms.TextBox textDec;
        private System.Windows.Forms.TextBox texEnc2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

