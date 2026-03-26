namespace HomePage.ScreenSavers
{
    partial class ScreenSaver
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
            this.components = new System.ComponentModel.Container();
            this.picShark = new System.Windows.Forms.PictureBox();
            this.picfish = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picShark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfish)).BeginInit();
            this.SuspendLayout();
            // 
            // picShark
            // 
            this.picShark.BackColor = System.Drawing.Color.Transparent;
            this.picShark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picShark.Image = global::HomePage.Properties.Resources._3;
            this.picShark.Location = new System.Drawing.Point(532, 80);
            this.picShark.Name = "picShark";
            this.picShark.Size = new System.Drawing.Size(357, 207);
            this.picShark.TabIndex = 1;
            this.picShark.TabStop = false;
            // 
            // picfish
            // 
            this.picfish.BackColor = System.Drawing.Color.Transparent;
            this.picfish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picfish.Enabled = false;
            this.picfish.Image = global::HomePage.Properties.Resources._1;
            this.picfish.Location = new System.Drawing.Point(158, 51);
            this.picfish.Name = "picfish";
            this.picfish.Size = new System.Drawing.Size(316, 297);
            this.picfish.TabIndex = 0;
            this.picfish.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ScreenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1249, 695);
            this.Controls.Add(this.picShark);
            this.Controls.Add(this.picfish);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSaver";
            this.Text = "ScreenSaver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreenSaver_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ScreenSaver_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenSaver_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picShark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picfish;
        private System.Windows.Forms.PictureBox picShark;
        private System.Windows.Forms.Timer timer1;
    }
}