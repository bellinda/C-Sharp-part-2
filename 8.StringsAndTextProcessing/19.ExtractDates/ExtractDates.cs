//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standart date format for Canada.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Globalization;

    class ExtractDates
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
            Console.WriteLine("Enter the text:");
            string text = Console.ReadLine();
            string pattern = @"[0-9]{1,2}[.][0-9]{1,2}[.][0-9]{4}";
            Match match = Regex.Match(text, pattern);
            while (match.Success)
            {
                DateTime date = DateTime.Parse(match.ToString());
                Console.WriteLine("{0:d}", date);
                match = match.NextMatch();
            }
        }
    }
