//1.Write a program that reads a year from the console and checks wheter it is a leap. Use DateTime.

using System;
using System.Collections.Generic;
    class LeapYear
    {
        static void Main()
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            bool leap = DateTime.IsLeapYear(year);
            Console.WriteLine("Is it leap? -> {0}", leap);
        }
    }

