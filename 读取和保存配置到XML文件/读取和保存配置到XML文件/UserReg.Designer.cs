namespace 读取和保存配置到XML文件
{
    partial class UserReg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comType = new System.Windows.Forms.ComboBox();
            this.texPwd = new System.Windows.Forms.TextBox();
            this.texUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.texPhone = new System.Windows.Forms.TextBox();
            this.radMan = new System.Windows.Forms.RadioButton();
            this.radWomen = new System.Windows.Forms.RadioButton();
            this.comYear = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comMonth = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comDay = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comPrince = new System.Windows.Forms.ComboBox();
            this.comCity = new System.Windows.Forms.ComboBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comType
            // 
            this.comType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comType.FormattingEnabled = true;
            this.comType.Items.AddRange(new object[] {
            "学生",
            "老师",
            "管理员"});
            this.comType.Location = new System.Drawing.Point(97, 154);
            this.comType.Name = "comType";
            this.comType.Size = new System.Drawing.Size(461, 20);
            this.comType.TabIndex = 2;
            // 
            // texPwd
            // 
            this.texPwd.Location = new System.Drawing.Point(97, 118);
            this.texPwd.Name = "texPwd";
            this.texPwd.Size = new System.Drawing.Size(461, 21);
            this.texPwd.TabIndex = 1;
            // 
            // texUserName
            // 
            this.texUserName.Location = new System.Drawing.Point(97, 82);
            this.texUserName.Name = "texUserName";
            this.texUserName.Size = new System.Drawing.Size(461, 21);
            this.texUserName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "用户类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "用户名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(232, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "用户注册";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "性别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "出生年月：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "联系方式：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "家庭地址：";
            // 
            // texPhone
            // 
            this.texPhone.Location = new System.Drawing.Point(97, 247);
            this.texPhone.Name = "texPhone";
            this.texPhone.Size = new System.Drawing.Size(461, 21);
            this.texPhone.TabIndex = 8;
            // 
            // radMan
            // 
            this.radMan.AutoSize = true;
            this.radMan.Location = new System.Drawing.Point(99, 182);
            this.radMan.Name = "radMan";
            this.radMan.Size = new System.Drawing.Size(35, 16);
            this.radMan.TabIndex = 3;
            this.radMan.TabStop = true;
            this.radMan.Text = "男";
            this.radMan.UseVisualStyleBackColor = true;
            // 
            // radWomen
            // 
            this.radWomen.AutoSize = true;
            this.radWomen.Location = new System.Drawing.Point(166, 182);
            this.radWomen.Name = "radWomen";
            this.radWomen.Size = new System.Drawing.Size(35, 16);
            this.radWomen.TabIndex = 4;
            this.radWomen.TabStop = true;
            this.radWomen.Text = "女";
            this.radWomen.UseVisualStyleBackColor = true;
            // 
            // comYear
            // 
            this.comYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comYear.FormattingEnabled = true;
            this.comYear.Location = new System.Drawing.Point(97, 214);
            this.comYear.Name = "comYear";
            this.comYear.Size = new System.Drawing.Size(120, 20);
            this.comYear.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "年";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(372, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "月";
            // 
            // comMonth
            // 
            this.comMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comMonth.FormattingEnabled = true;
            this.comMonth.Location = new System.Drawing.Point(246, 214);
            this.comMonth.Name = "comMonth";
            this.comMonth.Size = new System.Drawing.Size(120, 20);
            this.comMonth.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(541, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "日";
            // 
            // comDay
            // 
            this.comDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comDay.FormattingEnabled = true;
            this.comDay.Location = new System.Drawing.Point(395, 214);
            this.comDay.Name = "comDay";
            this.comDay.Size = new System.Drawing.Size(140, 20);
            this.comDay.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(310, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 5;
            this.label12.Text = "省";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(541, 285);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 5;
            this.label13.Text = "市";
            // 
            // comPrince
            // 
            this.comPrince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPrince.FormattingEnabled = true;
            this.comPrince.Items.AddRange(new object[] {
            "湖北省",
            "广东省",
            "浙江省"});
            this.comPrince.Location = new System.Drawing.Point(97, 280);
            this.comPrince.Name = "comPrince";
            this.comPrince.Size = new System.Drawing.Size(207, 20);
            this.comPrince.TabIndex = 9;
            // 
            // comCity
            // 
            this.comCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comCity.FormattingEnabled = true;
            this.comCity.Items.AddRange(new object[] {
            "荆州市",
            "中山市",
            "杭州市"});
            this.comCity.Location = new System.Drawing.Point(333, 280);
            this.comCity.Name = "comCity";
            this.comCity.Size = new System.Drawing.Size(202, 20);
            this.comCity.TabIndex = 10;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(328, 323);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(95, 33);
            this.btnCancle.TabIndex = 12;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(182, 323);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(95, 33);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // UserReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 368);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.radWomen);
            this.Controls.Add(this.radMan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comDay);
            this.Controls.Add(this.comCity);
            this.Controls.Add(this.comMonth);
            this.Controls.Add(this.comPrince);
            this.Controls.Add(this.comYear);
            this.Controls.Add(this.comType);
            this.Controls.Add(this.texPhone);
            this.Controls.Add(this.texPwd);
            this.Controls.Add(this.texUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户注册";
            this.Load += new System.EventHandler(this.UserReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comType;
        private System.Windows.Forms.TextBox texPwd;
        private System.Windows.Forms.TextBox texUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox texPhone;
        private System.Windows.Forms.RadioButton radMan;
        private System.Windows.Forms.RadioButton radWomen;
        private System.Windows.Forms.ComboBox comYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comMonth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comDay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comPrince;
        private System.Windows.Forms.ComboBox comCity;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSubmit;
    }
}