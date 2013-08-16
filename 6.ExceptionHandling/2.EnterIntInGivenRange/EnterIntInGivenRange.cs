//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start...end]. 
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers:
//        a1,a2,...,a10, such that 1 < a1 <...< a10 < 100

using System;
using System.Collections.Generic;
using System.IO;
    class EnterIntInGivenRange
    {
        public static void ReadNumber(int start, int end)
        {
            Console.WriteLine("Enter a number in the range [{0},{1}]", start, end);
            int number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                Console.WriteLine("The number is out of the given range");
                ReadNumber(start, end);
            }
        }

        static void Main()
        {
            Console.WriteLine("The numbers should be in increasing order:");
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    ReadNumber(1, 100);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number is too big or too small to be set as an integer");
                    i--;
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number");
                    i--;
                    continue;
                }
          }
            
        }
    }
