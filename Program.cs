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
                Console.WriteLine("Please enter a name: (leave empty to exit) ");
                string input = Console.ReadLine();
                // Break if the user hits ENTER without typing a name
                if (input == "")
                {
                    break;
                }
                Employee currentEmployee = new Employee(input, "Smith");
                employees.Add(currentEmployee);
            }
            // This is important!
            return employees;
            // This will be handed off to the caller method so it must be returned at the end of the method
        }
        static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
        static void Main(string[] args) // Entry Point to application
        {
            // This is our employee getting code now
            List<Employee> employees = GetEmployees();
            PrintEmployees(employees);
        }
    }
}
