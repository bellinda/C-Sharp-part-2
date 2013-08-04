using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.CountAppearance
{
    class CountAppearance
    {
        static int HowOftenAppearceANumber(int number, int[]array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (number == array[i])
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.Write("How long will be your array? ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the numbers of your array: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Which numbers' frequency are you looking for?");
            int search = int.Parse(Console.ReadLine());
            int counter = HowOftenAppearceANumber(search, arr);
            if (counter > 1)
            {
                Console.WriteLine("The number {0} appears {1} times in this array.", search, counter);
            }
            else
            {
                Console.WriteLine("The number {0} appears {1} time in this array.", search, counter);
            }
        }
    }
}
