//3. Write a program that prints to the console which day of the week is today. Use System.DateTime.

using System;
using System.Collections.Generic;
    class DayOfWeek
    {
        static void Main()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Today - {0} is {1}", today, today.DayOfWeek);
        }
    }
