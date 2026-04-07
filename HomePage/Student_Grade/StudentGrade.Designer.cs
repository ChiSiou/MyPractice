namespace HomePage
{
    partial class StudentGrade
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
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lt_Statistics = new System.Windows.Forms.ListBox();
            this.lvstudent_score = new System.Windows.Forms.ListView();
            this.studentname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderChinese = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderEnglish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderMath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderAvg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderHigh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderLow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btn_Statistics = new System.Windows.Forms.Button();
            this.btnrandom = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnrandom20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(134, 204);
            this.txtMath.Margin = new System.Windows.Forms.Padding(4);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(105, 34);
            this.txtMath.TabIndex = 15;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglish.Location = new System.Drawing.Point(134, 147);
            this.txtEnglish.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(105, 34);
            this.txtEnglish.TabIndex = 14;
            // 
            // txtChinese
            // 
            this.txtChinese.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChinese.Location = new System.Drawing.Point(134, 87);
            this.txtChinese.Margin = new System.Windows.Forms.Padding(4);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(105, 34);
            this.txtChinese.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(134, 26);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(105, 34);
            this.txtName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(42, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "數學 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(42, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "英文 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(42, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "國文 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "姓名 :";
            // 
            // lt_Statistics
            // 
            this.lt_Statistics.FormattingEnabled = true;
            this.lt_Statistics.ItemHeight = 15;
            this.lt_Statistics.Location = new System.Drawing.Point(271, 418);
            this.lt_Statistics.Margin = new System.Windows.Forms.Padding(4);
            this.lt_Statistics.Name = "lt_Statistics";
            this.lt_Statistics.Size = new System.Drawing.Size(563, 154);
            this.lt_Statistics.TabIndex = 21;
            // 
            // lvstudent_score
            // 
            this.lvstudent_score.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentname,
            this.HeaderChinese,
            this.HeaderEnglish,
            this.HeaderMath,
            this.HeaderTotal,
            this.HeaderAvg,
            this.HeaderHigh,
            this.HeaderLow});
            this.lvstudent_score.HideSelection = false;
            this.lvstudent_score.Location = new System.Drawing.Point(268, 13);
            this.lvstudent_score.Margin = new System.Windows.Forms.Padding(4);
            this.lvstudent_score.Name = "lvstudent_score";
            this.lvstudent_score.Size = new System.Drawing.Size(566, 390);
            this.lvstudent_score.TabIndex = 20;
            this.lvstudent_score.UseCompatibleStateImageBehavior = false;
            this.lvstudent_score.View = System.Windows.Forms.View.Details;
            // 
            // studentname
            // 
            this.studentname.Text = "姓名";
            this.studentname.Width = 86;
            // 
            // HeaderChinese
            // 
            this.HeaderChinese.Text = "國文";
            this.HeaderChinese.Width = 52;
            // 
            // HeaderEnglish
            // 
            this.HeaderEnglish.Text = "英文";
            this.HeaderEnglish.Width = 53;
            // 
            // HeaderMath
            // 
            this.HeaderMath.Text = "數學";
            this.HeaderMath.Width = 53;
            // 
            // HeaderTotal
            // 
            this.HeaderTotal.Text = "總分";
            this.HeaderTotal.Width = 54;
            // 
            // HeaderAvg
            // 
            this.HeaderAvg.Text = "平均";
            this.HeaderAvg.Width = 51;
            // 
            // HeaderHigh
            // 
            this.HeaderHigh.Text = "最高";
            this.HeaderHigh.Width = 107;
            // 
            // HeaderLow
            // 
            this.HeaderLow.Text = "最低";
            this.HeaderLow.Width = 113;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClearAll.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearAll.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnClearAll.Location = new System.Drawing.Point(46, 469);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(185, 45);
            this.btnClearAll.TabIndex = 25;
            this.btnClearAll.Text = "重設所有資料";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btn_Statistics
            // 
            this.btn_Statistics.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Statistics.Enabled = false;
            this.btn_Statistics.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Statistics.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Statistics.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Statistics.Location = new System.Drawing.Point(47, 382);
            this.btn_Statistics.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Statistics.Name = "btn_Statistics";
            this.btn_Statistics.Size = new System.Drawing.Size(185, 45);
            this.btn_Statistics.TabIndex = 24;
            this.btn_Statistics.Text = "各科統計";
            this.btn_Statistics.Click += new System.EventHandler(this.btn_Statistics_Click);
            // 
            // btnrandom
            // 
            this.btnrandom.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnrandom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnrandom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnrandom.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnrandom.Location = new System.Drawing.Point(47, 324);
            this.btnrandom.Margin = new System.Windows.Forms.Padding(4);
            this.btnrandom.Name = "btnrandom";
            this.btnrandom.Size = new System.Drawing.Size(185, 45);
            this.btnrandom.TabIndex = 23;
            this.btnrandom.Text = "隨機資料儲存";
            this.btnrandom.UseVisualStyleBackColor = false;
            this.btnrandom.Click += new System.EventHandler(this.btnrandom_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddStudent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddStudent.Location = new System.Drawing.Point(47, 264);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(185, 45);
            this.btnAddStudent.TabIndex = 22;
            this.btnAddStudent.Text = "加入學生資料";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnrandom20
            // 
            this.btnrandom20.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnrandom20.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnrandom20.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnrandom20.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnrandom20.Location = new System.Drawing.Point(47, 528);
            this.btnrandom20.Margin = new System.Windows.Forms.Padding(4);
            this.btnrandom20.Name = "btnrandom20";
            this.btnrandom20.Size = new System.Drawing.Size(185, 45);
            this.btnrandom20.TabIndex = 26;
            this.btnrandom20.Text = "隨機加入20筆資料";
            this.btnrandom20.UseVisualStyleBackColor = false;
            this.btnrandom20.Click += new System.EventHandler(this.btnrandom20_Click);
            // 
            // StudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(890, 590);
            this.Controls.Add(this.btnrandom20);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btn_Statistics);
            this.Controls.Add(this.btnrandom);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lt_Statistics);
            this.Controls.Add(this.lvstudent_score);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentGrade";
            this.Text = "StudentGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lt_Statistics;
        private System.Windows.Forms.ListView lvstudent_score;
        private System.Windows.Forms.ColumnHeader studentname;
        private System.Windows.Forms.ColumnHeader HeaderChinese;
        private System.Windows.Forms.ColumnHeader HeaderEnglish;
        private System.Windows.Forms.ColumnHeader HeaderMath;
        private System.Windows.Forms.ColumnHeader HeaderTotal;
        private System.Windows.Forms.ColumnHeader HeaderAvg;
        private System.Windows.Forms.ColumnHeader HeaderHigh;
        private System.Windows.Forms.ColumnHeader HeaderLow;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btn_Statistics;
        private System.Windows.Forms.Button btnrandom;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnrandom20;
    }
}