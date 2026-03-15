namespace HomePage
{
    partial class Pos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnwine = new System.Windows.Forms.Button();
            this.btnwhisky = new System.Windows.Forms.Button();
            this.btntequila = new System.Windows.Forms.Button();
            this.btnbeer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnpaycredit = new System.Windows.Forms.Button();
            this.btnpaycash = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.lvbuy = new System.Windows.Forms.ListView();
            this.colheadproduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadqty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colheadtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnwine);
            this.groupBox1.Controls.Add(this.btnwhisky);
            this.groupBox1.Controls.Add(this.btntequila);
            this.groupBox1.Controls.Add(this.btnbeer);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(72, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(288, 389);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜單Menu";
            // 
            // btnwine
            // 
            this.btnwine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnwine.Location = new System.Drawing.Point(145, 216);
            this.btnwine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnwine.Name = "btnwine";
            this.btnwine.Size = new System.Drawing.Size(115, 148);
            this.btnwine.TabIndex = 3;
            this.btnwine.Text = "紅酒 Wine $320";
            this.btnwine.UseVisualStyleBackColor = true;
            this.btnwine.Click += new System.EventHandler(this.btnwine_Click);
            // 
            // btnwhisky
            // 
            this.btnwhisky.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnwhisky.Location = new System.Drawing.Point(23, 216);
            this.btnwhisky.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnwhisky.Name = "btnwhisky";
            this.btnwhisky.Size = new System.Drawing.Size(115, 148);
            this.btnwhisky.TabIndex = 2;
            this.btnwhisky.Text = "威士忌 Whisky $350";
            this.btnwhisky.UseVisualStyleBackColor = true;
            this.btnwhisky.Click += new System.EventHandler(this.btnwhisky_Click);
            // 
            // btntequila
            // 
            this.btntequila.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btntequila.Location = new System.Drawing.Point(145, 54);
            this.btntequila.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntequila.Name = "btntequila";
            this.btntequila.Size = new System.Drawing.Size(115, 148);
            this.btntequila.TabIndex = 1;
            this.btntequila.Text = "龍舌蘭 Tequila $180";
            this.btntequila.UseVisualStyleBackColor = true;
            this.btntequila.Click += new System.EventHandler(this.btntequila_Click);
            // 
            // btnbeer
            // 
            this.btnbeer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnbeer.Location = new System.Drawing.Point(23, 54);
            this.btnbeer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbeer.Name = "btnbeer";
            this.btnbeer.Size = new System.Drawing.Size(115, 148);
            this.btnbeer.TabIndex = 0;
            this.btnbeer.Text = "啤酒 BEER $120";
            this.btnbeer.UseVisualStyleBackColor = true;
            this.btnbeer.Click += new System.EventHandler(this.btnbeer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttotalprice);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(400, 62);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(273, 138);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "總金額 Total Price";
            // 
            // txttotalprice
            // 
            this.txttotalprice.BackColor = System.Drawing.SystemColors.GrayText;
            this.txttotalprice.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txttotalprice.Location = new System.Drawing.Point(25, 60);
            this.txttotalprice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.Size = new System.Drawing.Size(211, 39);
            this.txttotalprice.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnpaycredit);
            this.groupBox3.Controls.Add(this.btnpaycash);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(405, 219);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(268, 138);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "付款方式";
            // 
            // btnpaycredit
            // 
            this.btnpaycredit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnpaycredit.Location = new System.Drawing.Point(137, 50);
            this.btnpaycredit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpaycredit.Name = "btnpaycredit";
            this.btnpaycredit.Size = new System.Drawing.Size(109, 39);
            this.btnpaycredit.TabIndex = 1;
            this.btnpaycredit.Text = "信用卡";
            this.btnpaycredit.UseVisualStyleBackColor = true;
            this.btnpaycredit.Click += new System.EventHandler(this.btnpaycredit_Click);
            // 
            // btnpaycash
            // 
            this.btnpaycash.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnpaycash.Location = new System.Drawing.Point(20, 50);
            this.btnpaycash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpaycash.Name = "btnpaycash";
            this.btnpaycash.Size = new System.Drawing.Size(109, 39);
            this.btnpaycash.TabIndex = 0;
            this.btnpaycash.Text = "現金";
            this.btnpaycash.UseVisualStyleBackColor = true;
            this.btnpaycash.Click += new System.EventHandler(this.btnpaycash_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnclear);
            this.groupBox4.Controls.Add(this.lvbuy);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(711, 62);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(301, 388);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "購物清單List";
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnclear.Location = new System.Drawing.Point(171, 336);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(109, 39);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "清除清單";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lvbuy
            // 
            this.lvbuy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colheadproduct,
            this.colheadqty,
            this.colheadtotal});
            this.lvbuy.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lvbuy.HideSelection = false;
            this.lvbuy.Location = new System.Drawing.Point(24, 40);
            this.lvbuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvbuy.Name = "lvbuy";
            this.lvbuy.Size = new System.Drawing.Size(255, 288);
            this.lvbuy.TabIndex = 0;
            this.lvbuy.UseCompatibleStateImageBehavior = false;
            this.lvbuy.View = System.Windows.Forms.View.Details;
            // 
            // colheadproduct
            // 
            this.colheadproduct.Text = "Product";
            this.colheadproduct.Width = 84;
            // 
            // colheadqty
            // 
            this.colheadqty.Text = "Qty";
            this.colheadqty.Width = 51;
            // 
            // colheadtotal
            // 
            this.colheadtotal.Text = "Total";
            // 
            // Pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 526);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pos";
            this.Text = "Pos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnbeer;
        private System.Windows.Forms.ListView lvbuy;
        private System.Windows.Forms.Button btnwine;
        private System.Windows.Forms.Button btnwhisky;
        private System.Windows.Forms.Button btntequila;
        private System.Windows.Forms.Button btnpaycredit;
        private System.Windows.Forms.Button btnpaycash;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txttotalprice;
        private System.Windows.Forms.ColumnHeader colheadproduct;
        private System.Windows.Forms.ColumnHeader colheadqty;
        private System.Windows.Forms.ColumnHeader colheadtotal;
    }
}