//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
// Example:
// Enter the first date: 27.02.2006
// Enter the second date: 
// Distance: 4 days

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

    class ReadAndCalculateDates
    {
        static void Main()
        {
            Console.Write("Enter the first date: ");
            string first = Console.ReadLine();
            DateTime firstDate = DateTime.ParseExact(first, "d.M.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Enter the second date: ");
            string second = Console.ReadLine();
            DateTime secondDate = DateTime.ParseExact(second, "d.M.yyyy", CultureInfo.InvariantCulture);
            TimeSpan distance = secondDate.Subtract(firstDate);
            Console.WriteLine("Distance: {0} days", distance.TotalDays );

        }
    }
