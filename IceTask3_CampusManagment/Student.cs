using System;
using System.Collections.Generic;
using System.Text;

namespace IceTask3_CampusManagment
{
    internal class Student : Person
    {
        public string StudentNumber { get; set; }
        public string Course { get; set; }
        public double[] Marks { get; set; }

        public Student(string name, string email, string id, string studentNumber, string course)
            : base(name, email, id)
        {
            StudentNumber = studentNumber;
            Course = course;
            Marks = new double[0];
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} | Email: {Email} | ID: {ID} | Student Number: {StudentNumber} | Course: {Course}");
        }
    }
}
