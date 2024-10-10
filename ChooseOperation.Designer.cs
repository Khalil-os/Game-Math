namespace Math_Game
{
    partial class ChooseOperation
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
            this.btAddition = new System.Windows.Forms.Button();
            this.btSubtraction = new System.Windows.Forms.Button();
            this.btMultiplication = new System.Windows.Forms.Button();
            this.btDivision = new System.Windows.Forms.Button();
            this.btMix = new System.Windows.Forms.Button();
            this.btReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberOfQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAddition
            // 
            this.btAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btAddition.Location = new System.Drawing.Point(56, 285);
            this.btAddition.Name = "btAddition";
            this.btAddition.Size = new System.Drawing.Size(214, 95);
            this.btAddition.TabIndex = 0;
            this.btAddition.Text = "Addition";
            this.btAddition.UseVisualStyleBackColor = true;
            this.btAddition.Click += new System.EventHandler(this.btAddition_Click);
            // 
            // btSubtraction
            // 
            this.btSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btSubtraction.Location = new System.Drawing.Point(315, 285);
            this.btSubtraction.Name = "btSubtraction";
            this.btSubtraction.Size = new System.Drawing.Size(244, 95);
            this.btSubtraction.TabIndex = 1;
            this.btSubtraction.Text = "Subtraction";
            this.btSubtraction.UseVisualStyleBackColor = true;
            this.btSubtraction.Click += new System.EventHandler(this.btSubtraction_Click);
            // 
            // btMultiplication
            // 
            this.btMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btMultiplication.Location = new System.Drawing.Point(604, 285);
            this.btMultiplication.Name = "btMultiplication";
            this.btMultiplication.Size = new System.Drawing.Size(283, 95);
            this.btMultiplication.TabIndex = 2;
            this.btMultiplication.Text = "Multiplication";
            this.btMultiplication.UseVisualStyleBackColor = true;
            this.btMultiplication.Click += new System.EventHandler(this.btMultiplication_Click);
            // 
            // btDivision
            // 
            this.btDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btDivision.Location = new System.Drawing.Point(932, 285);
            this.btDivision.Name = "btDivision";
            this.btDivision.Size = new System.Drawing.Size(182, 95);
            this.btDivision.TabIndex = 3;
            this.btDivision.Text = "Division";
            this.btDivision.UseVisualStyleBackColor = true;
            this.btDivision.Click += new System.EventHandler(this.btDivision_Click);
            // 
            // btMix
            // 
            this.btMix.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btMix.Location = new System.Drawing.Point(377, 413);
            this.btMix.Name = "btMix";
            this.btMix.Size = new System.Drawing.Size(182, 95);
            this.btMix.TabIndex = 4;
            this.btMix.Text = "Mixed";
            this.btMix.UseVisualStyleBackColor = true;
            this.btMix.Click += new System.EventHandler(this.btMix_Click);
            // 
            // btReturn
            // 
            this.btReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btReturn.Location = new System.Drawing.Point(604, 413);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(182, 95);
            this.btReturn.TabIndex = 5;
            this.btReturn.Text = "Return";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 83);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose Operation";
            // 
            // NumberOfQuestion
            // 
            this.NumberOfQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.NumberOfQuestion.Location = new System.Drawing.Point(459, 208);
            this.NumberOfQuestion.Name = "NumberOfQuestion";
            this.NumberOfQuestion.Size = new System.Drawing.Size(233, 44);
            this.NumberOfQuestion.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of Question";
            // 
            // ChooseOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 570);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberOfQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.btMix);
            this.Controls.Add(this.btDivision);
            this.Controls.Add(this.btMultiplication);
            this.Controls.Add(this.btSubtraction);
            this.Controls.Add(this.btAddition);
            this.Name = "ChooseOperation";
            this.Text = "ChooseOperation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAddition;
        private System.Windows.Forms.Button btSubtraction;
        private System.Windows.Forms.Button btMultiplication;
        private System.Windows.Forms.Button btDivision;
        private System.Windows.Forms.Button btMix;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberOfQuestion;
        private System.Windows.Forms.Label label2;
    }
}