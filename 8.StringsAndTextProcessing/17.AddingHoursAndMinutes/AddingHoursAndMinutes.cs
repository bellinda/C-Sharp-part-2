//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after
//6 hours and 30 minutes (in the same format) along with the day of week in Bulgaria.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

    class AddingHoursAndMinutes
    {
        static void Main()
        {
            Console.Write("Enter the day and time in format [day.month.year hour:minute:second]: ");
            string dateAndTime = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateAndTime, "d.M.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            date = date.AddHours(6);
            date = date.AddMinutes(30);
            Console.Write(date);
            DayOfWeek day = date.DayOfWeek;
            string dayOfWeek = day.ToString();
            switch (dayOfWeek)
            {
                case "Monday":
                    {
                        Console.WriteLine(" Понеделник");
                        break;
                    }
                case "Tuesday":
                    {
                        Console.WriteLine(" Вторник");
                        break;
                    }
                case "Wednesday":
                    {
                        Console.WriteLine(" Сряда");
                        break;
                    }
                case "Thursday":
                    {
                        Console.WriteLine(" Четвъртък");
                        break;
                    }
                case "Friday":
                    {
                        Console.WriteLine(" Петък");
                        break;
                    }
                case "Saturday":
                    {
                        Console.WriteLine(" Събота");
                        break;
                    }
                case "Sunday":
                    {
                        Console.WriteLine(" Неделя");
                        break;
                    }
            }
        }
    }
