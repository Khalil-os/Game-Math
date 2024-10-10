namespace Math_Game
{
    partial class ChooseDiff
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
            this.btReturn = new System.Windows.Forms.Button();
            this.btMix = new System.Windows.Forms.Button();
            this.btMultiplication = new System.Windows.Forms.Button();
            this.btSubtraction = new System.Windows.Forms.Button();
            this.btAddition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 83);
            this.label1.TabIndex = 13;
            this.label1.Text = "Choose Diffucilter";
            // 
            // btReturn
            // 
            this.btReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btReturn.Location = new System.Drawing.Point(617, 424);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(182, 95);
            this.btReturn.TabIndex = 12;
            this.btReturn.Text = "Return";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // btMix
            // 
            this.btMix.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btMix.Location = new System.Drawing.Point(390, 424);
            this.btMix.Name = "btMix";
            this.btMix.Size = new System.Drawing.Size(182, 95);
            this.btMix.TabIndex = 11;
            this.btMix.Text = "Mixed";
            this.btMix.UseVisualStyleBackColor = true;
            this.btMix.Click += new System.EventHandler(this.btMix_Click);
            // 
            // btMultiplication
            // 
            this.btMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btMultiplication.Location = new System.Drawing.Point(794, 296);
            this.btMultiplication.Name = "btMultiplication";
            this.btMultiplication.Size = new System.Drawing.Size(183, 95);
            this.btMultiplication.TabIndex = 9;
            this.btMultiplication.Text = "Hard";
            this.btMultiplication.UseVisualStyleBackColor = true;
            this.btMultiplication.Click += new System.EventHandler(this.btMultiplication_Click);
            // 
            // btSubtraction
            // 
            this.btSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btSubtraction.Location = new System.Drawing.Point(473, 296);
            this.btSubtraction.Name = "btSubtraction";
            this.btSubtraction.Size = new System.Drawing.Size(244, 95);
            this.btSubtraction.TabIndex = 8;
            this.btSubtraction.Text = "Medium";
            this.btSubtraction.UseVisualStyleBackColor = true;
            this.btSubtraction.Click += new System.EventHandler(this.btSubtraction_Click);
            // 
            // btAddition
            // 
            this.btAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btAddition.Location = new System.Drawing.Point(211, 296);
            this.btAddition.Name = "btAddition";
            this.btAddition.Size = new System.Drawing.Size(183, 95);
            this.btAddition.TabIndex = 7;
            this.btAddition.Text = "Easy";
            this.btAddition.UseVisualStyleBackColor = true;
            this.btAddition.Click += new System.EventHandler(this.btAddition_Click);
            // 
            // ChooseDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.btMix);
            this.Controls.Add(this.btMultiplication);
            this.Controls.Add(this.btSubtraction);
            this.Controls.Add(this.btAddition);
            this.Name = "ChooseDiff";
            this.Text = "ChooseDiff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Button btMix;
        private System.Windows.Forms.Button btMultiplication;
        private System.Windows.Forms.Button btSubtraction;
        private System.Windows.Forms.Button btAddition;
    }
}