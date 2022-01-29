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
            Console.WriteLine("My employees include {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]);
        }
    }
}
