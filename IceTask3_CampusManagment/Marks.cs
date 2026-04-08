using System;
using System.Collections.Generic;

namespace IceTask3_CampusManagment
{
    internal class Marks
    {
        private string _studentNumber;
        private string _subjectName;
        private double _score;

        public string StudentNumber
        {
            get { return _studentNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Student number cannot be empty.");
                _studentNumber = value;
            }
        }

        public string SubjectName
        {
            get { return _subjectName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Subject name cannot be empty.");
                _subjectName = value;
            }
        }

        public double Score
        {
            get { return _score; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("Score must be between 0 and 100.");
                _score = value;
            }
        }

        public Marks(string studentNumber, string subjectName, double score)
        {
            StudentNumber = studentNumber;
            SubjectName = subjectName;
            Score = score;
        }

        public string CalculateGrade()
        {
            if (_score >= 75) return "A";
            if (_score >= 65) return "B";
            if (_score >= 55) return "C";
            if (_score >= 50) return "D";
            return "F";
        }

        public bool IsPassed()
        {
            return _score >= 50;
        }

        public static double GetAverage(List<Marks> marksList)
        {
            if (marksList == null || marksList.Count == 0)
                throw new ArgumentException("Marks list cannot be empty.");

            double total = 0;
            foreach (Marks m in marksList)
            {
                total += m.Score;
            }
            return total / marksList.Count;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Student Number: {_studentNumber} | Subject: {_subjectName} | Score: {_score}% | Grade: {CalculateGrade()} | Status: {(IsPassed() ? "Passed" : "Failed")}");
        }
    }
}