namespace HomePage
{
    partial class loan
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
            this.btnpmt = new System.Windows.Forms.Button();
            this.bnttotal = new System.Windows.Forms.Button();
            this.bntreport = new System.Windows.Forms.Button();
            this.txtloan = new System.Windows.Forms.TextBox();
            this.txtterm = new System.Windows.Forms.TextBox();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.txtinitial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnpmt
            // 
            this.btnpmt.BackColor = System.Drawing.Color.Gray;
            this.btnpmt.FlatAppearance.BorderSize = 0;
            this.btnpmt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnpmt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnpmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpmt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnpmt.ForeColor = System.Drawing.SystemColors.Control;
            this.btnpmt.Location = new System.Drawing.Point(110, 380);
            this.btnpmt.Name = "btnpmt";
            this.btnpmt.Size = new System.Drawing.Size(86, 34);
            this.btnpmt.TabIndex = 0;
            this.btnpmt.Text = "PMT(月付)";
            this.btnpmt.UseVisualStyleBackColor = false;
            this.btnpmt.Click += new System.EventHandler(this.btnpmt_Click);
            // 
            // bnttotal
            // 
            this.bnttotal.BackColor = System.Drawing.Color.Gray;
            this.bnttotal.FlatAppearance.BorderSize = 0;
            this.bnttotal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.bnttotal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bnttotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnttotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bnttotal.ForeColor = System.Drawing.SystemColors.Control;
            this.bnttotal.Location = new System.Drawing.Point(205, 380);
            this.bnttotal.Name = "bnttotal";
            this.bnttotal.Size = new System.Drawing.Size(83, 34);
            this.bnttotal.TabIndex = 1;
            this.bnttotal.Text = "總付款";
            this.bnttotal.UseVisualStyleBackColor = false;
            this.bnttotal.Click += new System.EventHandler(this.bnttotal_Click);
            // 
            // bntreport
            // 
            this.bntreport.BackColor = System.Drawing.SystemColors.Highlight;
            this.bntreport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bntreport.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bntreport.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntreport.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bntreport.ForeColor = System.Drawing.SystemColors.Control;
            this.bntreport.Location = new System.Drawing.Point(312, 376);
            this.bntreport.Name = "bntreport";
            this.bntreport.Size = new System.Drawing.Size(114, 43);
            this.bntreport.TabIndex = 2;
            this.bntreport.Text = "Report";
            this.bntreport.UseVisualStyleBackColor = false;
            this.bntreport.Click += new System.EventHandler(this.bntreport_Click);
            // 
            // txtloan
            // 
            this.txtloan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtloan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtloan.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtloan.Location = new System.Drawing.Point(110, 83);
            this.txtloan.Name = "txtloan";
            this.txtloan.Size = new System.Drawing.Size(316, 29);
            this.txtloan.TabIndex = 3;
            // 
            // txtterm
            // 
            this.txtterm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtterm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtterm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtterm.Location = new System.Drawing.Point(110, 165);
            this.txtterm.Name = "txtterm";
            this.txtterm.Size = new System.Drawing.Size(316, 29);
            this.txtterm.TabIndex = 4;
            // 
            // txtrate
            // 
            this.txtrate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtrate.Location = new System.Drawing.Point(110, 245);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(316, 29);
            this.txtrate.TabIndex = 5;
            // 
            // txtinitial
            // 
            this.txtinitial.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtinitial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtinitial.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtinitial.Location = new System.Drawing.Point(110, 320);
            this.txtinitial.Name = "txtinitial";
            this.txtinitial.Size = new System.Drawing.Size(316, 29);
            this.txtinitial.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(111, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "貸款金額 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(111, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "利率(%) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(111, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "期限(年) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(111, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "頭期款 :";
            // 
            // loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtinitial);
            this.Controls.Add(this.txtrate);
            this.Controls.Add(this.txtterm);
            this.Controls.Add(this.txtloan);
            this.Controls.Add(this.bntreport);
            this.Controls.Add(this.bnttotal);
            this.Controls.Add(this.btnpmt);
            this.Name = "loan";
            this.Text = "代款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpmt;
        private System.Windows.Forms.Button bnttotal;
        private System.Windows.Forms.Button bntreport;
        private System.Windows.Forms.TextBox txtloan;
        private System.Windows.Forms.TextBox txtterm;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.TextBox txtinitial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}