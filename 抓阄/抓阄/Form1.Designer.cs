namespace 抓阄
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
            this.texReady = new System.Windows.Forms.TextBox();
            this.texSelected = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numSel = new System.Windows.Forms.NumericUpDown();
            this.btnGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSel)).BeginInit();
            this.SuspendLayout();
            // 
            // texReady
            // 
            this.texReady.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.texReady.Location = new System.Drawing.Point(1, 0);
            this.texReady.Multiline = true;
            this.texReady.Name = "texReady";
            this.texReady.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.texReady.Size = new System.Drawing.Size(173, 452);
            this.texReady.TabIndex = 0;
            this.texReady.TextChanged += new System.EventHandler(this.texReady_TextChanged);
            // 
            // texSelected
            // 
            this.texSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texSelected.Location = new System.Drawing.Point(421, 0);
            this.texSelected.Multiline = true;
            this.texSelected.Name = "texSelected";
            this.texSelected.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.texSelected.Size = new System.Drawing.Size(172, 452);
            this.texSelected.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(206, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "抽取数：";
            // 
            // numSel
            // 
            this.numSel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numSel.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numSel.Location = new System.Drawing.Point(277, 121);
            this.numSel.Name = "numSel";
            this.numSel.Size = new System.Drawing.Size(120, 25);
            this.numSel.TabIndex = 2;
            this.numSel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGo
            // 
            this.btnGo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGo.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGo.Location = new System.Drawing.Point(230, 310);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(132, 93);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "开始";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.numSel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texSelected);
            this.Controls.Add(this.texReady);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "随机抓阄";
            ((System.ComponentModel.ISupportInitialize)(this.numSel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texReady;
        private System.Windows.Forms.TextBox texSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSel;
        private System.Windows.Forms.Button btnGo;
    }
}

