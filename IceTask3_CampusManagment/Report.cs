using System;
using System.Collections.Generic;
using System.Text;

namespace IceTask3_CampusManagment
{
    internal class Report
    {
        //introducing lists from the other classes
        private List<Student> _students;
        private List<Marks> _marksList;

        public Report(List<Student> students, List<Marks> marksList)
        {
            _students = students;
            _marksList = marksList;

        }
        //method to retrieve and show the students marks
        public void getReport()
        {
            Console.WriteLine("\n--- Students Report ---");
            if (_students.Count == 0)
            {
                Console.WriteLine("There is currently no students to repot on");
            }

            foreach (Student s in _students)
            {
                Console.WriteLine($"\nName: {s.Name} Student Number: {s.StudentNumber}");

                List<Marks> studentMarks = _marksList.FindAll(m => m.StudentNumber == s.StudentNumber);

                if (studentMarks.Count == 0)
                {
                    Console.WriteLine("No marks recorded");
                }
                else
                {
                    foreach(Marks m in studentMarks)
                    {
                        Console.WriteLine($"  Subject: {m.SubjectName} | Score: {m.Score}% | Grade: {m.CalculateGrade()} | {(m.IsPassed() ? "Passed" : "Failed")}");
                    }

                    
                }
            }

            Console.WriteLine("\n--- End of report ---");

        }
    }
}
