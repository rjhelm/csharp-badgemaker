using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            // Collect user values until the value is an empty string
            while (true)
            {
                // Move the initial prompt inside the loop, so it repeats for each employee
                Console.WriteLine("Please enter a name: (leave empty to exit) ");
                // Change the input to firestName
                string firstName = Console.ReadLine();
                
                // Break if the user hits ENTER without typing a name
                if (firstName == "")
                {
                    break;
                }
                // Add a Console.ReadLine for each value
                Console.Write("Please enter a last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Please enter an employee ID: ");
                int id = Int32.Parse(Console.ReadLine());
                Console.Write("Please enter a photo URL: ");
                string photoUrl = Console.ReadLine();
                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }
            // This is important!
            return employees;
            // This will be handed off to the caller method so it must be returned at the end of the method
        }
        static void Main(string[] args) // Entry Point to application
        {
            // This is our employee getting code now
            List<Employee> employees = GetEmployees();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
        }
    }
}
