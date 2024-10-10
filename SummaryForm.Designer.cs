namespace Math_Game
{
    partial class SummaryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbNumberOfQuestion = new System.Windows.Forms.Label();
            this.lbNumberOfTrueAnswer = new System.Windows.Forms.Label();
            this.lbNumberOfFalseAnswer = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbPercentage = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 83);
            this.label1.TabIndex = 8;
            this.label1.Text = "Summary";
            // 
            // lbNumberOfQuestion
            // 
            this.lbNumberOfQuestion.AutoSize = true;
            this.lbNumberOfQuestion.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfQuestion.Location = new System.Drawing.Point(51, 220);
            this.lbNumberOfQuestion.Name = "lbNumberOfQuestion";
            this.lbNumberOfQuestion.Size = new System.Drawing.Size(457, 41);
            this.lbNumberOfQuestion.TabIndex = 9;
            this.lbNumberOfQuestion.Text = "Number of Question       : ";
            // 
            // lbNumberOfTrueAnswer
            // 
            this.lbNumberOfTrueAnswer.AutoSize = true;
            this.lbNumberOfTrueAnswer.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfTrueAnswer.Location = new System.Drawing.Point(51, 312);
            this.lbNumberOfTrueAnswer.Name = "lbNumberOfTrueAnswer";
            this.lbNumberOfTrueAnswer.Size = new System.Drawing.Size(460, 41);
            this.lbNumberOfTrueAnswer.TabIndex = 10;
            this.lbNumberOfTrueAnswer.Text = "Number of true Answer  : ";
            // 
            // lbNumberOfFalseAnswer
            // 
            this.lbNumberOfFalseAnswer.AutoSize = true;
            this.lbNumberOfFalseAnswer.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfFalseAnswer.Location = new System.Drawing.Point(51, 404);
            this.lbNumberOfFalseAnswer.Name = "lbNumberOfFalseAnswer";
            this.lbNumberOfFalseAnswer.Size = new System.Drawing.Size(461, 41);
            this.lbNumberOfFalseAnswer.TabIndex = 11;
            this.lbNumberOfFalseAnswer.Text = "Number of false Answer : ";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(216, 486);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(229, 41);
            this.lbTotal.TabIndex = 12;
            this.lbTotal.Text = "Total         : ";
            // 
            // lbPercentage
            // 
            this.lbPercentage.AutoSize = true;
            this.lbPercentage.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercentage.Location = new System.Drawing.Point(216, 568);
            this.lbPercentage.Name = "lbPercentage";
            this.lbPercentage.Size = new System.Drawing.Size(246, 41);
            this.lbPercentage.TabIndex = 13;
            this.lbPercentage.Text = "Percentage :  ";
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btExit.Location = new System.Drawing.Point(378, 661);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(195, 76);
            this.btExit.TabIndex = 18;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 790);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.lbPercentage);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbNumberOfFalseAnswer);
            this.Controls.Add(this.lbNumberOfTrueAnswer);
            this.Controls.Add(this.lbNumberOfQuestion);
            this.Controls.Add(this.label1);
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNumberOfQuestion;
        private System.Windows.Forms.Label lbNumberOfTrueAnswer;
        private System.Windows.Forms.Label lbNumberOfFalseAnswer;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbPercentage;
        private System.Windows.Forms.Button btExit;
    }
}