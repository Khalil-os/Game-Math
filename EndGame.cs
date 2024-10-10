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
    public partial class EndGame : Form
    {
        public EndGame()
        {
            InitializeComponent();
        }

        private void RePlay_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            this.Close();
            form.Show();
            Program.NumberOfQuestion = 3;
            Program.NumberOfIncorrectAnswer = 0;
            Program.NumberOfCorrectAnswer = 0;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btSummary_Click(object sender, EventArgs e)
        {
            Form form = new SummaryForm();
            form.ShowDialog();
        }
    }
}
