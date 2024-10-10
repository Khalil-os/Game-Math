using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game
{
    public partial class Game : Form
    {
        int Result;      
        bool End = false;
        int NumberOfQuestions = 0;

        public void Swap(ref string S1 , ref string S2)
        {
            string temp = S1;
            S1 = S2;
            S2 = temp;
        }

        public void Question()
        {
            Random random = new Random();

            switch (Program.Operation)
            {
                case Program.enOperations.Addition:
                    Operation.Text = "+";
                    switch (Program.Diff)
                    {
                        case Program.enDiff.Easy:
                            Num1.Text = random.Next(1, 21).ToString();
                            Num2.Text = random.Next(1, 21).ToString();
                            if (Convert.ToInt32(Num2.Text) > Convert.ToInt32(Num1.Text))
                            {
                                string temp1 = Num1.Text;
                                string temp2 = Num2.Text;
                                Swap(ref temp1, ref temp2);
                                Num1.Text = temp1;
                                Num2.Text = temp2;
                            }
                            Result = Convert.ToInt32(Num1.Text) + Convert.ToInt32(Num2.Text);
                            break;

                        case Program.enDiff.Medium:
                            Num1.Text = random.Next(20, 101).ToString();
                            Num2.Text = random.Next(20, 101).ToString();
                            if (Convert.ToInt32(Num2.Text) > Convert.ToInt32(Num1.Text))
                            {
                                string temp1 = Num1.Text;
                                string temp2 = Num2.Text;
                                Swap(ref temp1, ref temp2);
                                Num1.Text = temp1;
                                Num2.Text = temp2;
                            }
                            Result = Convert.ToInt32(Num1.Text) + Convert.ToInt32(Num2.Text);
                            break;

                        case Program.enDiff.Hard:
                            Num1.Text = random.Next(100, 1001).ToString();
                            Num2.Text = random.Next(100, 1001).ToString();
                            if (Convert.ToInt32(Num2.Text) > Convert.ToInt32(Num1.Text))
                            {
                                string temp1 = Num1.Text;
                                string temp2 = Num2.Text;
                                Swap(ref temp1, ref temp2);
                                Num1.Text = temp1;
                                Num2.Text = temp2;
                            }
                            Result = Convert.ToInt32(Num1.Text) + Convert.ToInt32(Num2.Text);
                            break;

                        case Program.enDiff.Mix:
                            Program.Diff = (Program.enDiff)random.Next(1, 4);
                            Question();
                            Program.Diff = Program.enDiff.Mix;
                            break;
                    }
                    break;

                case Program.enOperations.Subtraction:
                    Operation.Text = "-";
                    switch (Program.Diff)
                    {
                        case Program.enDiff.Easy:
                            Num1.Text = random.Next(1, 21).ToString();
                            Num2.Text = random.Next(1, 21).ToString();
                            if(Convert.ToInt32(Num2.Text) > Convert.ToInt32(Num1.Text))
                            {
                                string temp1 = Num1.Text;
                                string temp2 = Num2.Text;
                                Swap(ref temp1, ref temp2);
                                Num1.Text = temp1;
                                Num2.Text = temp2;
                            }
                            Result = Convert.ToInt32(Num1.Text) - Convert.ToInt32(Num2.Text);
                            break;

                        case Program.enDiff.Medium:
                            Num1.Text = random.Next(20, 101).ToString();
                            Num2.Text = random.Next(20, 101).ToString();
                            if (Convert.ToInt32(Num2.Text) > Convert.ToInt32(Num1.Text))
                            {
                                string temp1 = Num1.Text;
                                string temp2 = Num2.Text;
                                Swap(ref temp1, ref temp2);
                                Num1.Text = temp1;
                                Num2.Text = temp2;
                            }
                            Result = Convert.ToInt32(Num1.Text) - Convert.ToInt32(Num2.Text);
                            break;

                        case Program.enDiff.Hard:
                            Num1.Text = random.Next(100, 1001).ToString();
                            Num2.Text = random.Next(100, 1001).ToString();
                            if (Convert.ToInt32(Num2.Text) > Convert.ToInt32(Num1.Text))
                            {
                                string temp1 = Num1.Text;
                                string temp2 = Num2.Text;
                                Swap(ref temp1, ref temp2);
                                Num1.Text = temp1;
                                Num2.Text = temp2;
                            }
                            Result = Convert.ToInt32(Num1.Text) - Convert.ToInt32(Num2.Text);
                            break;

                        case Program.enDiff.Mix:
                            Program.Diff = (Program.enDiff)random.Next(1, 4);
                            Question();
                            Program.Diff = Program.enDiff.Mix;
                            break;
                    }
                    break;
                case Program.enOperations.Multiplication:
                    Operation.Text = "x";
                    switch (Program.Diff)
                    {
                        case Program.enDiff.Easy:
                            Num1.Text = random.Next(1, 21).ToString();
                            Num2.Text = random.Next(1, 21).ToString();
                            if (Convert.ToInt32(Num2.Text) > Convert.ToInt32(Num1.Text))
                            {
                                string temp1 = Num1.Text;
                                string temp2 = Num2.Text;
                                Swap(ref temp1, ref temp2);
                                Num1.Text = temp1;
                                Num2.Text = temp2;
                            }
                            Result = Convert.ToInt32(Num1.Text) * Convert.ToInt32(Num2.Text);
                            break;

                        case Program.enDiff.Medium:
                            Num1.Text = random.Next(20, 101).ToString();
                            Num2.Text = random.Next(20, 101).ToString();
                            if (Convert.ToInt32(Num2.Text) > Convert.ToInt32(Num1.Text))
                            {
                                string temp1 = Num1.Text;
                                string temp2 = Num2.Text;
                                Swap(ref temp1, ref temp2);
                                Num1.Text = temp1;
                                Num2.Text = temp2;
                            }
                            Result = Convert.ToInt32(Num1.Text) * Convert.ToInt32(Num2.Text);
                            break;

                        case Program.enDiff.Hard:
                            Num1.Text = random.Next(100, 1001).ToString();
                            Num2.Text = random.Next(100, 1001).ToString();
                            if (Convert.ToInt32(Num2.Text) > Convert.ToInt32(Num1.Text))
                            {
                                string temp1 = Num1.Text;
                                string temp2 = Num2.Text;
                                Swap(ref temp1, ref temp2);
                                Num1.Text = temp1;
                                Num2.Text = temp2;
                            }
                            Result = Convert.ToInt32(Num1.Text) * Convert.ToInt32(Num2.Text);
                            break;

                        case Program.enDiff.Mix:
                            Program.Diff = (Program.enDiff)random.Next(1, 4);
                            Question();
                            Program.Diff = Program.enDiff.Mix;
                            break;
                    }
                    break;
                case Program.enOperations.Division:
                    Operation.Text = "/";
                    switch (Program.Diff)
                    {
                        case Program.enDiff.Easy:
                            Num1.Text = random.Next(1, 21).ToString();
                            Num2.Text = random.Next(1, 21).ToString();
                            if (Convert.ToInt32(Num2.Text) > Convert.ToInt32(Num1.Text))
                            {
                                string temp1 = Num1.Text;
                                string temp2 = Num2.Text;
                                Swap(ref temp1, ref temp2);
                                Num1.Text = temp1;
                                Num2.Text = temp2;
                            }
                            Result = Convert.ToInt32(Num1.Text) / Convert.ToInt32(Num2.Text);
                            break;

                        case Program.enDiff.Medium:
                            Num1.Text = random.Next(20, 101).ToString();
                            Num2.Text = random.Next(20, 101).ToString();
                            if (Convert.ToInt32(Num2.Text) > Convert.ToInt32(Num1.Text))
                            {
                                string temp1 = Num1.Text;
                                string temp2 = Num2.Text;
                                Swap(ref temp1, ref temp2);
                                Num1.Text = temp1;
                                Num2.Text = temp2;
                            }
                            Result = Convert.ToInt32(Num1.Text) / Convert.ToInt32(Num2.Text);
                            break;

                        case Program.enDiff.Hard:
                            Num1.Text = random.Next(100, 1001).ToString();
                            Num2.Text = random.Next(100, 1001).ToString();
                            if (Convert.ToInt32(Num2.Text) > Convert.ToInt32(Num1.Text))
                            {
                                string temp1 = Num1.Text;
                                string temp2 = Num2.Text;
                                Swap(ref temp1, ref temp2);
                                Num1.Text = temp1;
                                Num2.Text = temp2;
                            }
                            Result = Convert.ToInt32(Num1.Text) / Convert.ToInt32(Num2.Text);
                            break;

                        case Program.enDiff.Mix:
                            Program.Diff = (Program.enDiff)random.Next(1, 4);
                            Question();
                            Program.Diff = Program.enDiff.Mix;
                            break;
                    }
                    break;
                case Program.enOperations.Mix:
                    Program.Operation = (Program.enOperations)random.Next(1, 5);
                    Question();
                    Program.Operation = Program.enOperations.Mix;
                    break;
            }
        }

        public Game()
        {
            InitializeComponent();
            Question();
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            Color Black = Color.Black;
            Pen Pen = new Pen(Black);
            Pen.Width = 10;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 230, 335, 370, 335);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(TimeBar.Value > TimeBar.Minimum)
            {
                Time.Text = (Convert.ToInt32(Time.Text) - 1).ToString();
                TimeBar.Value -= 1;
            }       
            else
            {
                timer1.Enabled = false;
                tbAnswer.BackColor = Color.Red;
                tbAnswer.ForeColor = Color.White;
                Program.NumberOfIncorrectAnswer++;
                NumberOfQuestions++;
                Answer.Visible = false;
                Next.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.AcceptButton = Next;
            Answer.Visible = false;
            Next.Visible= true;
            timer1.Enabled = false;
            if(tbAnswer.Text == Result.ToString())
            {
                tbAnswer.BackColor = Color.Green;
                tbAnswer.ForeColor = Color.White;
                Program.NumberOfCorrectAnswer++;
                NumberOfQuestions++;
            }
            else
            {
                tbAnswer.BackColor = Color.Red;
                tbAnswer.ForeColor = Color.White;
                Program.NumberOfIncorrectAnswer++;
                NumberOfQuestions++;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Question();
            this.AcceptButton = Answer;
            Next.Visible = false;
            Answer.Visible = true;
            tbAnswer.Text = "";
            tbAnswer.BackColor = Color.White;
            tbAnswer.ForeColor = Color.Black;
            Time.Text = "10";
            TimeBar.Value = 10;
            timer1.Enabled = true;
            if (End == true)
            {
                Form form = new EndGame();
                this.Close();
                form.Show();
            }     
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(Program.NumberOfQuestion <= NumberOfQuestions)
            {
                End = true;          
            }
        }
    }
}
