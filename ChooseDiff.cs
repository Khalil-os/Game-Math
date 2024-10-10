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
    public partial class ChooseDiff : Form
    {
        public ChooseDiff()
        {
            InitializeComponent();
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            Form frm = new ChooseOperation();
            this.Close();
            frm.Show();
        }

        private void btAddition_Click(object sender, EventArgs e)
        {
            Program.Diff = Program.enDiff.Easy;
            Form form = new Game();
            this.Close();
            form.Show();
        }

        private void btSubtraction_Click(object sender, EventArgs e)
        {
            Program.Diff = Program.enDiff.Medium;
            Form form = new Game();
            this.Close();
            form.Show();
        }

        private void btMultiplication_Click(object sender, EventArgs e)
        {
            Program.Diff = Program.enDiff.Hard;
            Form form = new Game();
            this.Close();
            form.Show();
        }

        private void btMix_Click(object sender, EventArgs e)
        {
            Program.Diff = Program.enDiff.Mix;
            Form form = new Game();
            this.Close();
            form.Show();
        }
    }
}
