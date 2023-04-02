namespace 高考倒计时
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labDay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labHour = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labMin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labSec = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(249, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(903, 173);
            this.label1.TabIndex = 0;
            this.label1.Text = "高 考 倒 计 时";
            // 
            // labDay
            // 
            this.labDay.BackColor = System.Drawing.Color.Black;
            this.labDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labDay.Font = new System.Drawing.Font("微软雅黑", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDay.Location = new System.Drawing.Point(0, 0);
            this.labDay.Name = "labDay";
            this.labDay.Size = new System.Drawing.Size(344, 161);
            this.labDay.TabIndex = 1;
            this.labDay.Text = "88";
            this.labDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.labDay);
            this.panel1.Location = new System.Drawing.Point(423, 390);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panel1.Size = new System.Drawing.Size(344, 163);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(824, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 88);
            this.label2.TabIndex = 0;
            this.label2.Text = "天";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.labHour);
            this.panel2.Location = new System.Drawing.Point(332, 659);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panel2.Size = new System.Drawing.Size(143, 117);
            this.panel2.TabIndex = 2;
            // 
            // labHour
            // 
            this.labHour.BackColor = System.Drawing.Color.Black;
            this.labHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labHour.Font = new System.Drawing.Font("微软雅黑", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labHour.Location = new System.Drawing.Point(0, 0);
            this.labHour.Name = "labHour";
            this.labHour.Size = new System.Drawing.Size(143, 115);
            this.labHour.TabIndex = 1;
            this.labHour.Text = "88";
            this.labHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(501, 706);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 70);
            this.label3.TabIndex = 0;
            this.label3.Text = "时";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(769, 706);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 70);
            this.label4.TabIndex = 0;
            this.label4.Text = "分";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.labMin);
            this.panel3.Location = new System.Drawing.Point(600, 659);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panel3.Size = new System.Drawing.Size(143, 117);
            this.panel3.TabIndex = 2;
            // 
            // labMin
            // 
            this.labMin.BackColor = System.Drawing.Color.Black;
            this.labMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labMin.Font = new System.Drawing.Font("微软雅黑", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMin.Location = new System.Drawing.Point(0, 0);
            this.labMin.Name = "labMin";
            this.labMin.Size = new System.Drawing.Size(143, 115);
            this.labMin.TabIndex = 1;
            this.labMin.Text = "88";
            this.labMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(1028, 706);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 70);
            this.label6.TabIndex = 0;
            this.label6.Text = "秒";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Controls.Add(this.labSec);
            this.panel4.Location = new System.Drawing.Point(859, 659);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panel4.Size = new System.Drawing.Size(143, 117);
            this.panel4.TabIndex = 2;
            // 
            // labSec
            // 
            this.labSec.BackColor = System.Drawing.Color.Black;
            this.labSec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labSec.Font = new System.Drawing.Font("微软雅黑", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSec.Location = new System.Drawing.Point(0, 0);
            this.labSec.Name = "labSec";
            this.labSec.Size = new System.Drawing.Size(143, 115);
            this.labSec.TabIndex = 1;
            this.labSec.Text = "88";
            this.labSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1463, 862);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labDay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labSec;
        private System.Windows.Forms.Timer timer1;
    }
}

