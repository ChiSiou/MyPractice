namespace HomePage
{
    partial class Paint
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
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.tkbSizeChange = new System.Windows.Forms.TrackBar();
            this.btnBrush = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRentangle = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.pickedcolor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSizeChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickedcolor)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(984, 561);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnColor
            // 
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.Location = new System.Drawing.Point(12, 12);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(67, 39);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tkbSizeChange
            // 
            this.tkbSizeChange.Location = new System.Drawing.Point(551, 17);
            this.tkbSizeChange.Maximum = 25;
            this.tkbSizeChange.Name = "tkbSizeChange";
            this.tkbSizeChange.Size = new System.Drawing.Size(323, 45);
            this.tkbSizeChange.TabIndex = 2;
            this.tkbSizeChange.TickFrequency = 2;
            this.tkbSizeChange.Scroll += new System.EventHandler(this.tkbSizeChange_Scroll);
            // 
            // btnBrush
            // 
            this.btnBrush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrush.Location = new System.Drawing.Point(229, 12);
            this.btnBrush.Name = "btnBrush";
            this.btnBrush.Size = new System.Drawing.Size(67, 39);
            this.btnBrush.TabIndex = 3;
            this.btnBrush.Text = "Brush";
            this.btnBrush.UseVisualStyleBackColor = true;
            this.btnBrush.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEraser.Location = new System.Drawing.Point(304, 12);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(67, 39);
            this.btnEraser.TabIndex = 4;
            this.btnEraser.Text = "Eraser";
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnLine
            // 
            this.btnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLine.Location = new System.Drawing.Point(379, 12);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(67, 39);
            this.btnLine.TabIndex = 5;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnRentangle
            // 
            this.btnRentangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRentangle.Location = new System.Drawing.Point(454, 12);
            this.btnRentangle.Name = "btnRentangle";
            this.btnRentangle.Size = new System.Drawing.Size(67, 39);
            this.btnRentangle.TabIndex = 6;
            this.btnRentangle.Text = "Rentangle";
            this.btnRentangle.UseVisualStyleBackColor = true;
            this.btnRentangle.Click += new System.EventHandler(this.btnRentangle_Click);
            // 
            // btnPen
            // 
            this.btnPen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPen.Location = new System.Drawing.Point(154, 12);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(67, 39);
            this.btnPen.TabIndex = 7;
            this.btnPen.Text = "Pen";
            this.btnPen.UseVisualStyleBackColor = true;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // pickedcolor
            // 
            this.pickedcolor.BackColor = System.Drawing.SystemColors.WindowText;
            this.pickedcolor.Location = new System.Drawing.Point(88, 17);
            this.pickedcolor.Name = "pickedcolor";
            this.pickedcolor.Size = new System.Drawing.Size(50, 33);
            this.pickedcolor.TabIndex = 8;
            this.pickedcolor.TabStop = false;
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pickedcolor);
            this.Controls.Add(this.btnPen);
            this.Controls.Add(this.btnRentangle);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnEraser);
            this.Controls.Add(this.btnBrush);
            this.Controls.Add(this.tkbSizeChange);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.pic);
            this.Name = "Paint";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSizeChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickedcolor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TrackBar tkbSizeChange;
        private System.Windows.Forms.Button btnBrush;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRentangle;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.PictureBox pickedcolor;
    }
}