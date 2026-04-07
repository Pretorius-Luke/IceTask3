using System;
using System.Collections.Generic;

namespace IceTask3_CampusManagment
{
    internal class Course
    {
        public static string CourseName { get; set; }
        private List<Student> _students;

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

            Console.Write("Enter Course Name: ");
            CourseName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(CourseName))
                throw new ArgumentException("Course name cannot be empty.");

            found.Course = CourseName;
            Console.WriteLine($"\n{found.Name} has been added to {CourseName}.");
        }
    }
}