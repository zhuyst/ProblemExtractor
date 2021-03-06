﻿using System;
using System.Collections.Generic;
using System.IO;
using ExcelDataReader;
using ProblemExtractor.Model;

namespace ProblemExtractor
{
    class ProblemService
    {
        private static ProblemService _instance;

        private const string ExcelName = "test.xlsx";

        private readonly List<Problem> _problems;

        private readonly Random _random;

        public static ProblemService GetInstance()
        {
            return _instance ?? (_instance = new ProblemService());
        }

        private ProblemService()
        {
            _problems = new List<Problem>();
            _random = new Random();
            InitProblems();
        }

        private void InitProblems()
        {
            var filePath = $@"{Environment.CurrentDirectory}/{ExcelName}";
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var i = 1;
                    do
                    {
                        while (reader.Read())
                        {
                            var problem = new Problem
                            {
                                Id = i++,
                                Content = reader.GetString(0)
                            };
                            _problems.Add(problem);
                        }
                    } while (reader.NextResult());
                }
            }
        }

        public List<Problem> ExtractProblems(int problemNum)
        {
            var list = new List<Problem>();

            var exists = new HashSet<int>();
            for (var i = 0; i < problemNum; i++)
            {
                while (true)
                {
                    var problem = _problems[_random.Next(_problems.Count - 1)];
                    if (exists.Contains(problem.Id)) continue;

                    list.Add(problem);
                    exists.Add(problem.Id);
                    break;
                }
            }

            return list;
        }
    }
}
