using System;
using DSkin.Forms;

namespace ProblemExtractor
{
    public partial class MainForm : DSkinForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private static void ShowProblemForm(int problemNum)
        {
            new ProblemForm(problemNum).ShowDialog();
        }

        private void EasyMode_Click(object sender, EventArgs e)
        {
            ShowProblemForm(1);
        }

        private void NormalMode_Click(object sender, EventArgs e)
        {
            ShowProblemForm(3);
        }

        private void HardMode_Click(object sender, EventArgs e)
        {
            ShowProblemForm(5);
        }
    }
}
