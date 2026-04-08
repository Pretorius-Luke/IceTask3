using System;
using System.Collections.Generic;
using System.Text;

namespace IceTask3_CampusManagment
{
    internal class Lecturer : Person
    {
        public string EmployeeId { get; set; }
        public string Department { get; set; }

        private static List<Lecturer> _lecturers = new List<Lecturer>();
        public static List<Lecturer> Lecturers => _lecturers;

        public Lecturer(string name, string email, string iD, string employeeId, string department)
            : base(name, email, iD)
        {
            EmployeeId = employeeId;
            Department = department;
        }

        public static void RegisterLecturer()
        {
            Console.WriteLine("\n--- Register New Lecturer ---");
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

                Console.Write("Enter Employee ID: ");
                string employeeId = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(employeeId))
                    throw new ArgumentException("Employee ID cannot be empty.");

                Console.Write("Enter Department: ");
                string department = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(department))
                    throw new ArgumentException("Department cannot be empty.");

                Lecturer lecturer = new Lecturer(name, email, id, employeeId, department);
                _lecturers.Add(lecturer);

                Console.WriteLine("\nLecturer registered successfully!");
                lecturer.DisplayInfo();
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

        public static void ViewAllLecturers()
        {
            Console.WriteLine("\n--- Registered Lecturers ---");
            if (_lecturers.Count == 0)
            {
                Console.WriteLine("No lecturers registered yet.");
                return;
            }

            foreach (Lecturer l in _lecturers)
            {
                l.DisplayInfo();
            }

            Console.WriteLine($"\nTotal Lecturers: {_lecturers.Count}");
        }

        public void DisplayLecturerInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Department: {Department}");
        }

        public void DisplayLecturerInfo(bool basicInfo)
        {
            if (basicInfo)
            {
                Console.WriteLine($"Employee ID: {EmployeeId}");
            }
            else
            {
                DisplayLecturerInfo();
            }
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Employee ID: {EmployeeId} | Department: {Department}");
        }
    }
}