using System;

namespace IceTask3_CampusManagment
{
    internal class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string ID { get; set; }

        public Person(string name, string email, string iD)
        {
            Name = name;
            Email = email;
            ID = iD;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} | Email: {Email} | ID: {ID}");
        }
    }
}