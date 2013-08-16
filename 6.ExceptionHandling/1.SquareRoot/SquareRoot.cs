//Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative,
//print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

using System;
using System.Collections.Generic;
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                SquareRootOfANumber();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }

        private static void SquareRootOfANumber()
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid number");
            }
            else
            {
                Console.WriteLine(Math.Sqrt(number));
            }
        }
    }
