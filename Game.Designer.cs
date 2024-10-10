namespace Math_Game
{
    partial class Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.TimeBar = new System.Windows.Forms.ProgressBar();
            this.Time = new System.Windows.Forms.Label();
            this.Num1 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.Label();
            this.Operation = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.process1 = new System.Diagnostics.Process();
            this.Answer = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 83);
            this.label1.TabIndex = 7;
            this.label1.Text = "Game";
            // 
            // TimeBar
            // 
            this.TimeBar.Location = new System.Drawing.Point(94, 230);
            this.TimeBar.Maximum = 10;
            this.TimeBar.Name = "TimeBar";
            this.TimeBar.Size = new System.Drawing.Size(721, 36);
            this.TimeBar.TabIndex = 8;
            this.TimeBar.Value = 10;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.Time.Location = new System.Drawing.Point(421, 157);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(66, 46);
            this.Time.TabIndex = 9;
            this.Time.Text = "10";
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.Num1.Location = new System.Drawing.Point(421, 343);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(66, 46);
            this.Num1.TabIndex = 10;
            this.Num1.Text = "10";
            // 
            // Num2
            // 
            this.Num2.AutoSize = true;
            this.Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.Num2.Location = new System.Drawing.Point(421, 437);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(66, 46);
            this.Num2.TabIndex = 11;
            this.Num2.Text = "10";
            // 
            // Operation
            // 
            this.Operation.AutoSize = true;
            this.Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.Operation.Location = new System.Drawing.Point(362, 394);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(44, 46);
            this.Operation.TabIndex = 12;
            this.Operation.Text = "+";
            // 
            // tbAnswer
            // 
            this.tbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbAnswer.Location = new System.Drawing.Point(348, 535);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(207, 53);
            this.tbAnswer.TabIndex = 13;
            this.tbAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Answer
            // 
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Answer.Location = new System.Drawing.Point(357, 629);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(195, 76);
            this.Answer.TabIndex = 16;
            this.Answer.Text = "Answer";
            this.Answer.UseVisualStyleBackColor = true;
            this.Answer.Click += new System.EventHandler(this.button3_Click);
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Next.Location = new System.Drawing.Point(360, 629);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(195, 76);
            this.Next.TabIndex = 17;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Visible = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Game
            // 
            this.AcceptButton = this.Answer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 766);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.TimeBar);
            this.Controls.Add(this.label1);
            this.Name = "Game";
            this.Text = "Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar TimeBar;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.Label Operation;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Button Answer;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Timer timer2;
    }
}