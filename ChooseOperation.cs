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
    public partial class ChooseOperation : Form
    {

        public ChooseOperation()
        {
            InitializeComponent();
        }

         
        private void btDivision_Click(object sender, EventArgs e)
        {
            Program.Operation = Program.enOperations.Division;
            if(NumberOfQuestion.Text != "")
                if (Convert.ToInt32(NumberOfQuestion.Text) > 0)
                    Program.NumberOfQuestion = Convert.ToInt32(NumberOfQuestion.Text);
            Form frm = new ChooseDiff();
            this.Close();
            frm.Show();
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            Form frm = new Form1();
            this.Close();
            frm.Show();
        }

        private void btAddition_Click(object sender, EventArgs e)
        {
            Program.Operation = Program.enOperations.Addition;
            if (NumberOfQuestion.Text != "")
                if (Convert.ToInt32(NumberOfQuestion.Text) > 0)
                    Program.NumberOfQuestion = Convert.ToInt32(NumberOfQuestion.Text);
            Form frm = new ChooseDiff();
            this.Close();
            frm.Show();
        }

        private void btSubtraction_Click(object sender, EventArgs e)
        {
            Program.Operation = Program.enOperations.Subtraction;
            if (NumberOfQuestion.Text != "")
                if (Convert.ToInt32(NumberOfQuestion.Text) > 0)
                    Program.NumberOfQuestion = Convert.ToInt32(NumberOfQuestion.Text);
            Form frm = new ChooseDiff();
            this.Close();
            frm.Show();
        }

        private void btMultiplication_Click(object sender, EventArgs e)
        {
            Program.Operation = Program.enOperations.Multiplication;
            if (NumberOfQuestion.Text != "")
                if (Convert.ToInt32(NumberOfQuestion.Text) > 0)
                    Program.NumberOfQuestion = Convert.ToInt32(NumberOfQuestion.Text);
            Form frm = new ChooseDiff();
            this.Close();
            frm.Show();
        }

        private void btMix_Click(object sender, EventArgs e)
        {
            Program.Operation = Program.enOperations.Mix;
            if (NumberOfQuestion.Text != "")
                if (Convert.ToInt32(NumberOfQuestion.Text) > 0)
                    Program.NumberOfQuestion = Convert.ToInt32(NumberOfQuestion.Text);
            Form frm = new ChooseDiff();
            this.Close();
            frm.Show();
        }
    }
}
