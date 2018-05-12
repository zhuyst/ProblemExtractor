using DSkin.Controls;
using ProblemExtractor.Model;

namespace WindowsFormsControlLibrary
{
    public partial class ProblemListItem: DSkinUserControl
    {
        private readonly Problem _problem;

        public ProblemListItem(Problem problem)
        {
            InitializeComponent();
            _problem = problem;
        }

        private void ProblemListItem_Load(object sender, System.EventArgs e)
        {
            ContentLabel.Text = _problem.Content;
        }
    }
}
