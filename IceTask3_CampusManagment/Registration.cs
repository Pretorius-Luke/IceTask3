using System;
using System.Collections.Generic;

namespace IceTask3_CampusManagment
{
    internal class Registration
    {
        private List<Student> _students = new List<Student>();
        private List<Marks> _marksList = new List<Marks>();

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

        public void CaptureMarks()
        {
            Console.WriteLine("\n--- Capture Marks ---");
            try
            {
                Console.Write("Enter Student Number: ");
                string studentNumber = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(studentNumber))
                    throw new ArgumentException("Student number cannot be empty.");

                Console.Write("Enter Subject Name: ");
                string subject = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(subject))
                    throw new ArgumentException("Subject name cannot be empty.");

                Console.Write("Enter Score (0-100): ");
                string scoreInput = Console.ReadLine();
                if (!double.TryParse(scoreInput, out double score))
                    throw new ArgumentException("Score must be a valid number.");

                Marks mark = new Marks(studentNumber, subject, score);
                _marksList.Add(mark);

                Console.WriteLine("\nMark captured successfully!");
                mark.DisplayInfo();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nUnexpected error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("--- Capture process complete ---\n");
            }
        }

        public void ViewMarks()
        {
            Console.WriteLine("\n--- All Marks ---");
            if (_marksList.Count == 0)
            {
                Console.WriteLine("No marks captured yet.");
                return;
            }

            foreach (Marks m in _marksList)
            {
                m.DisplayInfo();
            }

            Console.WriteLine($"\nClass Average: {Marks.GetAverage(_marksList):F2}%");
        }
    }
}