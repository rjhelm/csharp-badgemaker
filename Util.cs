using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Drawing;

namespace CatWorx.BadgeMaker
{
    class Util
    {
        // Method declared as static
        public static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                string template = "{0, -10}\t{1, -20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
            }
        }
        public static void MakeCSV(List<Employee> employees)
        {
            // Check to see if "data" folder exists
            if (!Directory.Exists("data"))
            {
                // If not create it
                Directory.CreateDirectory("data");
            }
            using (StreamWriter file = new StreamWriter("data/employees.csv"))
            {
                file.WriteLine("ID, Name, Photo URL");
                // Loop over employees
                for (int i = 0; i < employees.Count; i++)
                {
                    // Write the employee to the file
                    string template = "{0}, {1}, {2}";
                    file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
                }
            }
        }
        public static void MakeBadges(List<Employee> employees) 
        {
            // Layout Variables
            int BADGE_WIDTH = 669;
            int BADGE_HEIGHT = 1044;

            int COMPANY_NAME_START_X = 0;
            int COMPANY_NAME_START_Y = 110;
            int COMPANY_NAME_WIDTH = 100;

            int PHOTO_START_X = 184;
            int PHOTO_START_Y = 215;
            int PHOTO_WIDTH = 302;
            int PHOTO_HEIGHT = 302;

            int EMPLOYEE_NAME_START_X = 0;
            int EMPLOYEE_NAME_START_Y = 560;
            int EMPLOYEE_NAME_WIDTH = BADGE_WIDTH;
            int EMPLOYEE_NAME_HEIGHT = 100;

            int EMPLOYEE_ID_START_X = 0;
            int EMPLOYEE_ID_START_Y = 690;
            int EMPLOYEE_ID_WIDTH = BADGE_WIDTH;
            int EMPLOYEE_ID_HEIGHT = 100;

            // Create Image
            Image newImage = Image.FromFile("badge.png");
            newImage.Save("data/employeeBadge.png");

            using(WebClient client = new WebClient())
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    Image photo = Image.FromStream(client.OpenRead(employees[i].GetPhotoUrl()));
                    Image background = Image.FromFile("badge.png");
                    Image badge = new Bitmap(BADGE_WIDTH, BADGE_HEIGHT);
                    Graphics graphic = Graphics.FromImage(badge);
                    graphic.DrawImage(background, new Rectangle(0, 0,BADGE_WIDTH, BADGE_HEIGHT));
                    graphic.DrawImage(photo, new Rectangle(PHOTO_START_X, PHOTO_START_Y, PHOTO_WIDTH, PHOTO_HEIGHT));
                }
            }
        }

    }
}