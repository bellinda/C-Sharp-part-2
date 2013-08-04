using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.GetMax
{
    class GetMaxMethod
    {
        static int GetMax(int a, int b)
        {
            int max = a;
            if (a < b)
            {
                max = b;
            }
            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter three integers: ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int firstBigger = GetMax(number1, number2);
            int secondBigger = GetMax(firstBigger, number3);
            Console.WriteLine("The biggest one is {0}.", secondBigger);
        }
    }
}
