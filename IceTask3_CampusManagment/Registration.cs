using System;
using System.Collections.Generic;
using System.Text;

namespace IceTask3_CampusManagment
{
    internal class Registration
    {
        private List<Student> _students = new List<Student>();

        public void RegisterStudent()
        {
            Console.WriteLine("\n--- Register New Student ---");
            try
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                    throw new ArgumentException("Name cannot be empty.");

                Console.Write("Enter Email: ");
                string email = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                    throw new ArgumentException("Invalid email address.");

                Console.Write("Enter ID: ");
                string id = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(id))
                    throw new ArgumentException("ID cannot be empty.");

                Console.Write("Enter Student Number: ");
                string studentNumber = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(studentNumber))
                    throw new ArgumentException("Student number cannot be empty.");

                Console.Write("Enter Course: ");
                string course = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(course))
                    throw new ArgumentException("Course cannot be empty.");

                Student student = new Student(name, email, id, studentNumber, course);
                _students.Add(student);

                Console.WriteLine("\nStudent registered successfully!");
                student.DisplayInfo();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\nRegistration Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nUnexpected error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("--- Registration process complete ---\n");
            }
        }

        public void ViewAllStudents()
        {
            Console.WriteLine("\n--- Registered Students ---");
            if (_students.Count == 0)
            {
                Console.WriteLine("No students registered yet.");
                return;
            }

            foreach (Student s in _students)
            {
                s.DisplayInfo();
            }

            Console.WriteLine($"\nTotal Students: {_students.Count}");
        }

    }
}
