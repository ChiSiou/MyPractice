namespace HomePage
{
    partial class HomePage
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnpos = new System.Windows.Forms.Button();
            this.btnloan = new System.Windows.Forms.Button();
            this.btn0703_Hello = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1924, 1055);
            this.splitContainer1.SplitterDistance = 93;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(155, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "C#HomeWork";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Wheat;
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.btnpos);
            this.splitContainer2.Panel1.Controls.Add(this.btnloan);
            this.splitContainer2.Panel1.Controls.Add(this.btn0703_Hello);
            this.splitContainer2.Size = new System.Drawing.Size(1924, 957);
            this.splitContainer2.SplitterDistance = 291;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnpos
            // 
            this.btnpos.BackColor = System.Drawing.Color.RosyBrown;
            this.btnpos.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnpos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnpos.Location = new System.Drawing.Point(27, 216);
            this.btnpos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpos.Name = "btnpos";
            this.btnpos.Size = new System.Drawing.Size(235, 48);
            this.btnpos.TabIndex = 2;
            this.btnpos.Text = "0705_POS";
            this.btnpos.UseVisualStyleBackColor = false;
            this.btnpos.Click += new System.EventHandler(this.btnpos_Click);
            // 
            // btnloan
            // 
            this.btnloan.BackColor = System.Drawing.Color.RosyBrown;
            this.btnloan.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnloan.ForeColor = System.Drawing.SystemColors.Control;
            this.btnloan.Location = new System.Drawing.Point(27, 142);
            this.btnloan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnloan.Name = "btnloan";
            this.btnloan.Size = new System.Drawing.Size(235, 48);
            this.btnloan.TabIndex = 1;
            this.btnloan.Text = "0704_Loan";
            this.btnloan.UseVisualStyleBackColor = false;
            this.btnloan.Click += new System.EventHandler(this.btnloan_Click);
            // 
            // btn0703_Hello
            // 
            this.btn0703_Hello.BackColor = System.Drawing.Color.RosyBrown;
            this.btn0703_Hello.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn0703_Hello.ForeColor = System.Drawing.SystemColors.Control;
            this.btn0703_Hello.Location = new System.Drawing.Point(27, 72);
            this.btn0703_Hello.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn0703_Hello.Name = "btn0703_Hello";
            this.btn0703_Hello.Size = new System.Drawing.Size(235, 48);
            this.btn0703_Hello.TabIndex = 0;
            this.btn0703_Hello.Text = "0703_Hello";
            this.btn0703_Hello.UseVisualStyleBackColor = false;
            this.btn0703_Hello.Click += new System.EventHandler(this.btn0703_Hello_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(27, 284);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "0708_Student_StructForm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomePage";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn0703_Hello;
        private System.Windows.Forms.Button btnloan;
        private System.Windows.Forms.Button btnpos;
        private System.Windows.Forms.Button button1;
    }
}

