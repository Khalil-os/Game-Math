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
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
            lbNumberOfQuestion.Text += Program.NumberOfQuestion.ToString();
            lbNumberOfTrueAnswer.Text += Program.NumberOfCorrectAnswer.ToString();
            lbNumberOfFalseAnswer.Text += Program.NumberOfIncorrectAnswer.ToString();
            lbTotal.Text += Program.NumberOfCorrectAnswer.ToString() + "/" + Program.NumberOfQuestion.ToString();
            double Percentage = ((double)Program.NumberOfCorrectAnswer / (double)Program.NumberOfQuestion) * 100;
            lbPercentage.Text += Percentage.ToString("F2")+"%";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
