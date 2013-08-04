using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.ReverseTheDigits
{
    class ReverseTheDigits
    {
        static void ReverseDigits(int number)
        {
            int k = number;                              // save the first value of number for later
            int newNumber;
            int count = 0;                               //prove how many digits does the element contain
            while (number / 10 != 0)
            {
                count++;
                number = number / 10;
            }
            count++;                                    //because it's last digit is equal to number % 10 and number/10 can't find it
            int[] digits = new int[count];
            number = k;
            for (int i = 0; i < count; i++)
            {
                digits[i] = number % 10;
                number = number / 10;                
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(digits[i]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            ReverseDigits(num);
        }
    }
}
