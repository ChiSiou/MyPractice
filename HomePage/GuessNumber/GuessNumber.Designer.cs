namespace HomePage
{
    partial class GuessNumber
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
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.lbshowGuessResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGuess.Location = new System.Drawing.Point(52, 164);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(116, 55);
            this.btnGuess.TabIndex = 0;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnShowAnswer
            // 
            this.btnShowAnswer.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowAnswer.Location = new System.Drawing.Point(224, 165);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(129, 55);
            this.btnShowAnswer.TabIndex = 1;
            this.btnShowAnswer.Text = "Show Answer";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            this.btnShowAnswer.Click += new System.EventHandler(this.btnShowAnswer_Click);
            // 
            // lbshowGuessResult
            // 
            this.lbshowGuessResult.AutoSize = true;
            this.lbshowGuessResult.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbshowGuessResult.Location = new System.Drawing.Point(48, 85);
            this.lbshowGuessResult.Name = "lbshowGuessResult";
            this.lbshowGuessResult.Size = new System.Drawing.Size(305, 24);
            this.lbshowGuessResult.TabIndex = 2;
            this.lbshowGuessResult.Text = "Please Select a Number 1 to 100";
            // 
            // GuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 267);
            this.Controls.Add(this.lbshowGuessResult);
            this.Controls.Add(this.btnShowAnswer);
            this.Controls.Add(this.btnGuess);
            this.Location = new System.Drawing.Point(400, 400);
            this.Name = "GuessNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GuessNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnShowAnswer;
        private System.Windows.Forms.Label lbshowGuessResult;
    }
}