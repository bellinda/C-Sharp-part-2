//You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum.
//Example:   string = "43 68 9 23 318" -> result = 461

using System;
using System.Collections.Generic;
    class ReadAndCalculateIntFromString
    {
        static void Main()
        {
            Console.Write("Enter te string woth the numbers, separated by spaces: ");
            string seq = Console.ReadLine();
            Console.WriteLine("The sum of the numbers = {0}", CalculateFromString(seq));
        }

        private static int CalculateFromString(string seq)
        {
            int sum = 0;
            string[] numbers = seq.Split(' ');
            for (int i = 0; i < numbers.Length; i++)
            {
                int num = int.Parse(numbers[i]);
                sum += num;
            }
            return sum;
        }
    }
