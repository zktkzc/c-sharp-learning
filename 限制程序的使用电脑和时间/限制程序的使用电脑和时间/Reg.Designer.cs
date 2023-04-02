namespace 限制程序的使用电脑和时间
{
    partial class Reg
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
            this.label1 = new System.Windows.Forms.Label();
            this.texMachineCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.texRegCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "机器码：";
            // 
            // texMachineCode
            // 
            this.texMachineCode.Location = new System.Drawing.Point(101, 23);
            this.texMachineCode.Name = "texMachineCode";
            this.texMachineCode.ReadOnly = true;
            this.texMachineCode.Size = new System.Drawing.Size(404, 23);
            this.texMachineCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "注册码：";
            // 
            // texRegCode
            // 
            this.texRegCode.Location = new System.Drawing.Point(101, 64);
            this.texRegCode.Multiline = true;
            this.texRegCode.Name = "texRegCode";
            this.texRegCode.Size = new System.Drawing.Size(404, 153);
            this.texRegCode.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-2, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 1);
            this.panel1.TabIndex = 2;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(453, 248);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(93, 26);
            this.btnReg.TabIndex = 3;
            this.btnReg.Text = "注册（&R）";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 286);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.texRegCode);
            this.Controls.Add(this.texMachineCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.Shown += new System.EventHandler(this.Reg_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texMachineCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texRegCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReg;
    }
}