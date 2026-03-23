namespace HomePage
{
    partial class StudentScore
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
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.txtchinese = new System.Windows.Forms.TextBox();
            this.txtenglish = new System.Windows.Forms.TextBox();
            this.txtmath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnhighlow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lthighlow = new System.Windows.Forms.ListBox();
            this.ltscore = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtstudentname
            // 
            this.txtstudentname.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtstudentname.Location = new System.Drawing.Point(132, 59);
            this.txtstudentname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(133, 32);
            this.txtstudentname.TabIndex = 0;
            // 
            // txtchinese
            // 
            this.txtchinese.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtchinese.Location = new System.Drawing.Point(132, 126);
            this.txtchinese.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtchinese.Name = "txtchinese";
            this.txtchinese.Size = new System.Drawing.Size(133, 32);
            this.txtchinese.TabIndex = 1;
            // 
            // txtenglish
            // 
            this.txtenglish.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtenglish.Location = new System.Drawing.Point(132, 192);
            this.txtenglish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtenglish.Name = "txtenglish";
            this.txtenglish.Size = new System.Drawing.Size(133, 32);
            this.txtenglish.TabIndex = 2;
            // 
            // txtmath
            // 
            this.txtmath.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtmath.Location = new System.Drawing.Point(132, 254);
            this.txtmath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmath.Name = "txtmath";
            this.txtmath.Size = new System.Drawing.Size(133, 32);
            this.txtmath.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(64, 315);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "儲存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnhighlow
            // 
            this.btnhighlow.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnhighlow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnhighlow.Location = new System.Drawing.Point(404, 319);
            this.btnhighlow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnhighlow.Name = "btnhighlow";
            this.btnhighlow.Size = new System.Drawing.Size(138, 41);
            this.btnhighlow.TabIndex = 6;
            this.btnhighlow.Text = "高分/最低分科目";
            this.btnhighlow.UseVisualStyleBackColor = true;
            this.btnhighlow.Click += new System.EventHandler(this.btnhighlow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lthighlow);
            this.groupBox1.Controls.Add(this.ltscore);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(307, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(236, 279);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // lthighlow
            // 
            this.lthighlow.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lthighlow.FormattingEnabled = true;
            this.lthighlow.ItemHeight = 18;
            this.lthighlow.Location = new System.Drawing.Point(14, 183);
            this.lthighlow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lthighlow.Name = "lthighlow";
            this.lthighlow.Size = new System.Drawing.Size(206, 58);
            this.lthighlow.TabIndex = 1;
            // 
            // ltscore
            // 
            this.ltscore.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ltscore.FormattingEnabled = true;
            this.ltscore.ItemHeight = 23;
            this.ltscore.Location = new System.Drawing.Point(14, 31);
            this.ltscore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ltscore.Name = "ltscore";
            this.ltscore.Size = new System.Drawing.Size(207, 142);
            this.ltscore.TabIndex = 0;
            this.ltscore.SelectedIndexChanged += new System.EventHandler(this.ltscore_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(65, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "姓名 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(61, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = " 國文 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(65, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "英文 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(65, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "數學 :";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(155, 315);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "顯示儲存內容";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StudentScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 401);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnhighlow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmath);
            this.Controls.Add(this.txtenglish);
            this.Controls.Add(this.txtchinese);
            this.Controls.Add(this.txtstudentname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentScore";
            this.Text = "StudentScore";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.TextBox txtchinese;
        private System.Windows.Forms.TextBox txtenglish;
        private System.Windows.Forms.TextBox txtmath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnhighlow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lthighlow;
        private System.Windows.Forms.ListBox ltscore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}