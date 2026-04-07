namespace HomePage.MyCul
{
    partial class FrmClac
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
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btbtime = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtanswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(210, 21);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(62, 41);
            this.btnplus.TabIndex = 0;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(210, 76);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(62, 41);
            this.btnminus.TabIndex = 1;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btbtime
            // 
            this.btbtime.Location = new System.Drawing.Point(210, 131);
            this.btbtime.Name = "btbtime";
            this.btbtime.Size = new System.Drawing.Size(62, 41);
            this.btbtime.TabIndex = 2;
            this.btbtime.Text = "*";
            this.btbtime.UseVisualStyleBackColor = true;
            this.btbtime.Click += new System.EventHandler(this.btbtime_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(210, 186);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(62, 41);
            this.btndiv.TabIndex = 3;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtnum1.Location = new System.Drawing.Point(48, 56);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(115, 27);
            this.txtnum1.TabIndex = 4;
            // 
            // txtnum2
            // 
            this.txtnum2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtnum2.Location = new System.Drawing.Point(48, 121);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(115, 27);
            this.txtnum2.TabIndex = 5;
            // 
            // txtanswer
            // 
            this.txtanswer.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtanswer.Location = new System.Drawing.Point(48, 186);
            this.txtanswer.Name = "txtanswer";
            this.txtanswer.Size = new System.Drawing.Size(115, 27);
            this.txtanswer.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "NUM1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "NUM2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Answer";
            // 
            // FrmClac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 250);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtanswer);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btbtime);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnplus);
            this.Name = "FrmClac";
            this.Text = "FrmClac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btbtime;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtanswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}