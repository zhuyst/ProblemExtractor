using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSkin.Forms;
using ExcelDataReader;

namespace ProblemExtractor
{
    public partial class MainForm : DSkinForm
    {
        private const string ExcelName = "test.xlsx";

        private List<Problem> _problems;

        public MainForm()
        {
            InitializeComponent();

            _problems = new List<Problem>();
            InitProblems();
        }

        private void InitProblems()
        {
            var filePath = $@"{Environment.CurrentDirectory}/{ExcelName}";
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {
                        while (reader.Read())
                        {
                            var problem = new Problem();
                            _problems.Add(problem);

                            Debug.WriteLine(reader.GetValue(0));
                            Debug.WriteLine(reader.GetValue(1));
                        }
                    } while (reader.NextResult());
                }
            }
        }
    }
}
