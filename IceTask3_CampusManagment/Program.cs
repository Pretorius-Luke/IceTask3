
//members in group ST10447071, ST10446993, ST10448212, ST10445792, ST10495237

using IceTask3_CampusManagment;
using System.Data;

//Person per1 = new Person("steve","steve@gmail.com","St104999999");
//per1.DisplayInfo();

Registration registration = new Registration();

bool running = true;
while (running)
{
    Console.WriteLine("\n=== Campus Management System ===");
    Console.WriteLine("1. Register Student");
    Console.WriteLine("2. View All Students");
    Console.WriteLine("3. Exit");
    Console.Write("Choose an option: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            registration.RegisterStudent();
            break;
        case "2":
            registration.ViewAllStudents();
            break;
        case "3":
            running = false;
            Console.WriteLine("Goodbye!");
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}