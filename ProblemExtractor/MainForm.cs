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

        private void dSkinNewPanel1_Click(object sender, EventArgs e)
        {
            ShowProblemForm(1);
        }

        private void dSkinNewPanel2_Click(object sender, EventArgs e)
        {
            ShowProblemForm(3);
        }

        private void dSkinNewPanel3_Click(object sender, EventArgs e)
        {
            ShowProblemForm(5);
        }
    }
}
