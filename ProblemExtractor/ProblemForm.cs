using System;
using System.Collections.Generic;
using WindowsFormsControlLibrary;
using DSkin.Forms;
using ProblemExtractor.Model;

namespace ProblemExtractor
{
    public partial class ProblemForm : DSkinForm
    {
        private readonly int _problemNum;

        private readonly ProblemService _problemService;

        public ProblemForm(int problemNum)
        {
            InitializeComponent();
            _problemNum = problemNum;
            _problemService = ProblemService.GetInstance();
        }

        private void ProblemForm_Load(object sender, EventArgs e)
        {
            var list = _problemService.ExtractProblems(_problemNum);
            SetProblemList(list);
        }

        private void SetProblemList(IEnumerable<Problem> problems)
        {
            ProblemListPanel.Controls.Clear();
            foreach (var problem in problems)
            {
                var control = new ProblemListItem(problem);
                ProblemListPanel.Controls.Add(control);
            }
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            var list = _problemService.ExtractProblems(_problemNum);
            SetProblemList(list);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
