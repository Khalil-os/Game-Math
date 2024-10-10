using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game
{
    internal static class Program
    {
        public enum enOperations
        {
            Addition = 1,
            Subtraction = 2,
            Multiplication = 3,
            Division = 4,
            Mix = 5
        }

        public enum enDiff
        {
            Easy = 1,
            Medium = 2,
            Hard = 3,
            Mix = 4
        }

        public static int NumberOfCorrectAnswer = 0;

        public static int NumberOfIncorrectAnswer = 0;

        public static int NumberOfQuestion = 3;

        public static enOperations Operation;

        public static enDiff Diff;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
