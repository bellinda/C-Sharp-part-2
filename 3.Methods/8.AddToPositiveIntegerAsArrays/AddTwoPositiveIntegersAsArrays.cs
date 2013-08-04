using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.AddToPositiveIntegerAsArrays
{
    class AddTwoPositiveIntegersAsArrays
    {
        static void AddIntegersAsArrays(short[] firstNum, short[] secondNum)
        {
            short[] added = new short[firstNum.Length];
            added[0] = (short)((firstNum[0] + secondNum[0]) % 10);
            for (int i = 1; i < added.Length; i++)
            {
                if (i == (added.Length - 1))
                {
                    added[i] = (short)((firstNum[i] + secondNum[i] + (firstNum[i - 1] + secondNum[i - 1]) / 10)  
                       + (((firstNum[i - 1] + secondNum[i - 1]) % 10 + (firstNum[i - 2] + secondNum[i - 2]) / 10) / 10));
                }
                else
                    added[i] = (short)(((firstNum[i] + secondNum[i]) % 10 + (firstNum[i - 1] + secondNum[i - 1]) / 10) % 10);
            }
            for (int i = (added.Length - 1); i >= 0; i--)
            {
                Console.Write(added[i]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("How many digits have your numbers?");
            int digits = int.Parse(Console.ReadLine());
            short[] number1 = new short[digits];
            Console.WriteLine("Enter the digits of your first number:");
            for (int i = (digits - 1); i >= 0; i--)                           //the last digit is with index 0
            {
                number1[i] = short.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the digits of your second number:");
            short[] number2 = new short[digits];
            for (int i = digits - 1; i >= 0; i--)
            {
                number2[i] = short.Parse(Console.ReadLine());
            }
            AddIntegersAsArrays(number1, number2);
        }
    }
}
