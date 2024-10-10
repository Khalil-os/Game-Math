namespace Math_Game
{
    partial class EndGame
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
            this.RePlay = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.btSummary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(188, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 123);
            this.label1.TabIndex = 8;
            this.label1.Text = "End Game";
            // 
            // RePlay
            // 
            this.RePlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.RePlay.Location = new System.Drawing.Point(251, 313);
            this.RePlay.Name = "RePlay";
            this.RePlay.Size = new System.Drawing.Size(195, 76);
            this.RePlay.TabIndex = 15;
            this.RePlay.Text = "RePlay";
            this.RePlay.UseVisualStyleBackColor = true;
            this.RePlay.Click += new System.EventHandler(this.RePlay_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Exit.Location = new System.Drawing.Point(516, 313);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(195, 76);
            this.Exit.TabIndex = 16;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btSummary
            // 
            this.btSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btSummary.Location = new System.Drawing.Point(363, 423);
            this.btSummary.Name = "btSummary";
            this.btSummary.Size = new System.Drawing.Size(232, 76);
            this.btSummary.TabIndex = 17;
            this.btSummary.Text = "Summary";
            this.btSummary.UseVisualStyleBackColor = true;
            this.btSummary.Click += new System.EventHandler(this.btSummary_Click);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 530);
            this.Controls.Add(this.btSummary);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.RePlay);
            this.Controls.Add(this.label1);
            this.Name = "EndGame";
            this.Text = "EndGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RePlay;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button btSummary;
    }
}