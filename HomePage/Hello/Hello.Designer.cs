namespace HomePage
{
    partial class Hello
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
            this.btnsayhello = new System.Windows.Forms.Button();
            this.btnsayhi = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtenglishname = new System.Windows.Forms.TextBox();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.txtzodiac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsayhello
            // 
            this.btnsayhello.Location = new System.Drawing.Point(189, 305);
            this.btnsayhello.Name = "btnsayhello";
            this.btnsayhello.Size = new System.Drawing.Size(93, 34);
            this.btnsayhello.TabIndex = 0;
            this.btnsayhello.Text = "Say Hello !";
            this.btnsayhello.UseVisualStyleBackColor = true;
            this.btnsayhello.Click += new System.EventHandler(this.btnsayhello_Click);
            // 
            // btnsayhi
            // 
            this.btnsayhi.Location = new System.Drawing.Point(288, 304);
            this.btnsayhi.Name = "btnsayhi";
            this.btnsayhi.Size = new System.Drawing.Size(88, 35);
            this.btnsayhi.TabIndex = 1;
            this.btnsayhi.Text = "Say Hi!";
            this.btnsayhi.UseVisualStyleBackColor = true;
            this.btnsayhi.Click += new System.EventHandler(this.btnsayhi_Click);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtname.Location = new System.Drawing.Point(192, 55);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(184, 29);
            this.txtname.TabIndex = 2;
            // 
            // txtenglishname
            // 
            this.txtenglishname.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtenglishname.Location = new System.Drawing.Point(192, 124);
            this.txtenglishname.Name = "txtenglishname";
            this.txtenglishname.Size = new System.Drawing.Size(184, 29);
            this.txtenglishname.TabIndex = 3;
            // 
            // txtgender
            // 
            this.txtgender.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtgender.Location = new System.Drawing.Point(192, 188);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(184, 29);
            this.txtgender.TabIndex = 4;
            // 
            // txtzodiac
            // 
            this.txtzodiac.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtzodiac.Location = new System.Drawing.Point(192, 251);
            this.txtzodiac.Name = "txtzodiac";
            this.txtzodiac.Size = new System.Drawing.Size(184, 27);
            this.txtzodiac.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(75, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "姓名 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(39, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "English Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(75, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "性別 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(75, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "星座 :";
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 391);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtzodiac);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.txtenglishname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnsayhi);
            this.Controls.Add(this.btnsayhello);
            this.Name = "Hello";
            this.Text = "Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsayhello;
        private System.Windows.Forms.Button btnsayhi;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtenglishname;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.TextBox txtzodiac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}