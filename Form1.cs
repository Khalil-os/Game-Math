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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            Form form = new ChooseOperation();
            this.Hide();
            form.ShowDialog();
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
