using System;
using System.Collections.Generic;
using System.Text;

namespace IceTask3_CampusManagment
{
    internal class Lecturer : Person
    {

        public string EmployeeId { get; set; }
        public string Department { get; set; }

        //constructor to initialize the Lecturer properties
        public Lecturer(string name, string email, string iD, string employeeId, string department)
            : base(name, email, iD)
        {
            EmployeeId = employeeId;
            Department = department;
            Console.WriteLine("Lecturer constructor called");
        }

        
        //Method to display the lecturer information
        
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

        // Override the DisplayInfo method from Person class
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Employee ID: {EmployeeId} | Department: {Department}");
        }
    }
}
