namespace 体重指数_BMI_计算
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
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.labBMI = new System.Windows.Forms.Label();
            this.texBMI = new System.Windows.Forms.TextBox();
            this.labDes = new System.Windows.Forms.Label();
            this.texDes = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.radMan = new System.Windows.Forms.RadioButton();
            this.radWomen = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入身高：";
            // 
            // numHeight
            // 
            this.numHeight.DecimalPlaces = 2;
            this.numHeight.Location = new System.Drawing.Point(183, 30);
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(120, 25);
            this.numHeight.TabIndex = 1;
            this.numHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "米（m）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "请输入体重：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "千克（kg）";
            // 
            // numWeight
            // 
            this.numWeight.DecimalPlaces = 2;
            this.numWeight.Location = new System.Drawing.Point(183, 75);
            this.numWeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(120, 25);
            this.numWeight.TabIndex = 1;
            this.numWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labBMI
            // 
            this.labBMI.AutoSize = true;
            this.labBMI.Location = new System.Drawing.Point(84, 160);
            this.labBMI.Name = "labBMI";
            this.labBMI.Size = new System.Drawing.Size(116, 20);
            this.labBMI.TabIndex = 0;
            this.labBMI.Text = "体重指数(BMI)：";
            // 
            // texBMI
            // 
            this.texBMI.Location = new System.Drawing.Point(203, 157);
            this.texBMI.Name = "texBMI";
            this.texBMI.ReadOnly = true;
            this.texBMI.Size = new System.Drawing.Size(100, 25);
            this.texBMI.TabIndex = 2;
            this.texBMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labDes
            // 
            this.labDes.AutoSize = true;
            this.labDes.Location = new System.Drawing.Point(84, 204);
            this.labDes.Name = "labDes";
            this.labDes.Size = new System.Drawing.Size(79, 20);
            this.labDes.TabIndex = 0;
            this.labDes.Text = "体重描述：";
            // 
            // texDes
            // 
            this.texDes.Location = new System.Drawing.Point(183, 201);
            this.texDes.Name = "texDes";
            this.texDes.ReadOnly = true;
            this.texDes.Size = new System.Drawing.Size(120, 25);
            this.texDes.TabIndex = 2;
            this.texDes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 1);
            this.panel1.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(345, 269);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 41);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(242, 269);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(97, 41);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "计算(&C)";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "请选择性别：";
            // 
            // radMan
            // 
            this.radMan.AutoSize = true;
            this.radMan.Checked = true;
            this.radMan.Location = new System.Drawing.Point(183, 118);
            this.radMan.Name = "radMan";
            this.radMan.Size = new System.Drawing.Size(41, 24);
            this.radMan.TabIndex = 5;
            this.radMan.TabStop = true;
            this.radMan.Text = "男";
            this.radMan.UseVisualStyleBackColor = true;
            // 
            // radWomen
            // 
            this.radWomen.AutoSize = true;
            this.radWomen.Location = new System.Drawing.Point(242, 118);
            this.radWomen.Name = "radWomen";
            this.radWomen.Size = new System.Drawing.Size(41, 24);
            this.radWomen.TabIndex = 5;
            this.radWomen.Text = "女";
            this.radWomen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 321);
            this.Controls.Add(this.radWomen);
            this.Controls.Add(this.radMan);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.texDes);
            this.Controls.Add(this.texBMI);
            this.Controls.Add(this.numWeight);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labDes);
            this.Controls.Add(this.labBMI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "体重指数（BMI）计算";
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.Label labBMI;
        private System.Windows.Forms.TextBox texBMI;
        private System.Windows.Forms.Label labDes;
        private System.Windows.Forms.TextBox texDes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radMan;
        private System.Windows.Forms.RadioButton radWomen;
    }
}

