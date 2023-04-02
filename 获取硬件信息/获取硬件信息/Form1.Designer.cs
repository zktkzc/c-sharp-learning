namespace 获取硬件信息
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.texMACAddr = new System.Windows.Forms.TextBox();
            this.texCPUSn = new System.Windows.Forms.TextBox();
            this.texDiskSn = new System.Windows.Forms.TextBox();
            this.texBoardSn = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAC地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "CPU编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "硬盘序列号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "主板编号：";
            // 
            // texMACAddr
            // 
            this.texMACAddr.Location = new System.Drawing.Point(135, 26);
            this.texMACAddr.Name = "texMACAddr";
            this.texMACAddr.ReadOnly = true;
            this.texMACAddr.Size = new System.Drawing.Size(315, 29);
            this.texMACAddr.TabIndex = 1;
            // 
            // texCPUSn
            // 
            this.texCPUSn.Location = new System.Drawing.Point(135, 72);
            this.texCPUSn.Name = "texCPUSn";
            this.texCPUSn.ReadOnly = true;
            this.texCPUSn.Size = new System.Drawing.Size(315, 29);
            this.texCPUSn.TabIndex = 1;
            // 
            // texDiskSn
            // 
            this.texDiskSn.Location = new System.Drawing.Point(135, 118);
            this.texDiskSn.Name = "texDiskSn";
            this.texDiskSn.ReadOnly = true;
            this.texDiskSn.Size = new System.Drawing.Size(315, 29);
            this.texDiskSn.TabIndex = 1;
            // 
            // texBoardSn
            // 
            this.texBoardSn.Location = new System.Drawing.Point(135, 164);
            this.texBoardSn.Name = "texBoardSn";
            this.texBoardSn.ReadOnly = true;
            this.texBoardSn.Size = new System.Drawing.Size(315, 29);
            this.texBoardSn.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(1, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 1);
            this.panel1.TabIndex = 2;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(248, 219);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(231, 44);
            this.btnGetInfo.TabIndex = 3;
            this.btnGetInfo.Text = "获取信息（&R）";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 272);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.texBoardSn);
            this.Controls.Add(this.texDiskSn);
            this.Controls.Add(this.texCPUSn);
            this.Controls.Add(this.texMACAddr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "获取硬件信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texMACAddr;
        private System.Windows.Forms.TextBox texCPUSn;
        private System.Windows.Forms.TextBox texDiskSn;
        private System.Windows.Forms.TextBox texBoardSn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGetInfo;
    }
}

