using System;
using System.Collections.Generic;

namespace IceTask3_CampusManagment
{
    internal class Course
    {
        public static string CourseName { get; set; }
        private List<Student> _students;

        private List<string> _availableCourses = new List<string>
        {
            "Computer Science",
            "Information Technology",
            "Software Engineering",
            "Cybersecurity",
            "Data Science"
        };

        public Course(List<Student> students)
        {
            _students = students;
        }

        public void AddToCourse()
        {
            if (_students.Count == 0)
            {
                Console.WriteLine("No students registered yet.");
                return;
            }

            Console.Write("\nEnter the Student Number: ");
            string studentNumber = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(studentNumber))
                throw new ArgumentException("Student number cannot be empty.");

            Student found = null;
            foreach (Student s in _students)
            {
                if (s.StudentNumber == studentNumber)
                {
                    found = s;
                    break;
                }
            }

            if (found == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.WriteLine("\nAvailable Courses:");
            for (int i = 0; i < _availableCourses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_availableCourses[i]}");
            }

            Console.Write("Select a course (enter number): ");
            string courseInput = Console.ReadLine();

            if (!int.TryParse(courseInput, out int courseChoice) || courseChoice < 1 || courseChoice > _availableCourses.Count)
                throw new ArgumentException("Invalid course selection.");

            CourseName = _availableCourses[courseChoice - 1];
            found.Course = CourseName;

            Console.WriteLine($"\n{found.Name} has been added to {CourseName}.");
        }
    }
}