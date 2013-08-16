//5.Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Collections.Generic;
    class WorkdaysBetweenTodayAndGivenDate
    {
        static List<DateTime> holidays = new List<DateTime>() {
                                    DateTime.Parse("1.1.2014"),
                                    DateTime.Parse("1.1.2015"),
                                    DateTime.Parse("1.1.2016"),
                                    DateTime.Parse("1.1.2017"),
                                    DateTime.Parse("3.3.2014"),
                                    DateTime.Parse("3.3.2015"),
                                    DateTime.Parse("3.3.2016"),
                                    DateTime.Parse("3.3.2017"),
                                    DateTime.Parse("1.5.2014"),
                                    DateTime.Parse("1.5.2015"),
                                    DateTime.Parse("1.5.2016"),
                                    DateTime.Parse("1.5.2017"),
                                    DateTime.Parse("20.4.2014"),
                                    DateTime.Parse("12.4.2015"),
                                    DateTime.Parse("1.5.2016"),
                                    DateTime.Parse("16.4.2017"),
                                    DateTime.Parse("6.5.2014"),
                                    DateTime.Parse("6.5.2015"),
                                    DateTime.Parse("6.5.2016"),
                                    DateTime.Parse("6.5.2017"),
                                    DateTime.Parse("24.5.2014"),
                                    DateTime.Parse("24.5.2015"),
                                    DateTime.Parse("24.5.2016"),
                                    DateTime.Parse("24.5.2017"),
                                    DateTime.Parse("6.9.2013"),
                                    DateTime.Parse("6.9.2014"),
                                    DateTime.Parse("6.9.2015"),
                                    DateTime.Parse("6.9.2016"),
                                    DateTime.Parse("6.9.2017"),
                                    DateTime.Parse("22.9.2013"),
                                    DateTime.Parse("22.9.2014"),
                                    DateTime.Parse("22.9.2015"),
                                    DateTime.Parse("22.9.2016"),
                                    DateTime.Parse("22.9.2017"),
                                    DateTime.Parse("1.11.2013"),
                                    DateTime.Parse("1.11.2014"),
                                    DateTime.Parse("1.11.2015"),
                                    DateTime.Parse("1.11.2016"),
                                    DateTime.Parse("1.11.2017"),
                                    DateTime.Parse("24.12.2013"),
                                    DateTime.Parse("24.12.2014"),
                                    DateTime.Parse("24.12.2015"),
                                    DateTime.Parse("24.12.2016"),
                                    DateTime.Parse("24.12.2017"),
                                    DateTime.Parse("25.12.2013"),
                                    DateTime.Parse("25.12.2014"),
                                    DateTime.Parse("25.12.2015"),
                                    DateTime.Parse("25.12.2016"),
                                    DateTime.Parse("25.12.2017"),
                                    DateTime.Parse("26.12.2013"),
                                    DateTime.Parse("26.12.2014"),
                                    DateTime.Parse("26.12.2015"),
                                    DateTime.Parse("26.12.2016"),
                                    DateTime.Parse("26.12.2017")
        };

        static List<string> workDays = new List<string>() {   
                                    "Monday",
                                    "Tuesday",
                                    "Wednesday",
                                    "Thursday",
                                    "Friday"
                                };


        static void Main()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("Enter the end date (it should be till the end of 2017 and separeted with points): ");
            DateTime nextDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Number of work days until {0:dd.MM.yyyy} (without the end date) = {1}", nextDate, CountingWorkDays(today, nextDate));
            Console.WriteLine();
            
            
        }

        private static int CountingWorkDays(DateTime today, DateTime endDate)
        {
            int counter = 0;
            while (today != endDate)
            {
                if (!holidays.Contains(today) && workDays.Contains(today.DayOfWeek.ToString()))
                {
                    counter++;
                }
                
                today = today.AddDays(1);
            }
            return counter;
        }
    }
