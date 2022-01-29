using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static List<string> GetEmployees()
        {
            List<string> employees = new List<string>();
            // Collect user values until the value is an empty string
            while (true)
            {
                Console.WriteLine("Please enter a name: (leave empty to exit) ");
                string input = Console.ReadLine();
                // Break if the user hits ENTER without typing a name
                if (input == "")
                {
                    break;
                }
                Employee currentEmployee = new Employee();
                employees.Add(input);
            }
            // This is important!
            return employees;
            // This will be handed off to the caller method so it must be returned at the end of the method
        }
        static void PrintEmployees(List<string> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
        static void Main(string[] args) // Entry Point to application
        {
            // This is our employee getting code now
            List<string> employees = GetEmployees();
            PrintEmployees(employees);
        }
    }
}
