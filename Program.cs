using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        // Main must be nested inside a class Only one entry point
        static void Main(string[] args) // Entry Point to application
        {
            List<string> employees = new List<string>(){ "adam", "amy" };

            employees.Add("barbara");
            employees.Add("billy");
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
