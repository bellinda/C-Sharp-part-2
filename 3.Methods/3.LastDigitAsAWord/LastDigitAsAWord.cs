using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.LastDigitAsAWord
{
    class LastDigitAsAWord
    {
        static void ReturnsLastDigitAsWord(int num)
        {
            int digit = num % 10;
            switch (digit)
            {
                case 0:
                    Console.WriteLine("It's last digit is zero.");
                    break;
                case 1:
                    Console.WriteLine("It's last digit is one.");
                    break;
                case 2:
                    Console.WriteLine("It's last digit is two.");
                    break;
                case 3:
                    Console.WriteLine("It's last digit is three.");
                    break;
                case 4:
                    Console.WriteLine("It's last digit is four.");
                    break;
                case 5:
                    Console.WriteLine("It's last digit is five.");
                    break;
                case 6:
                    Console.WriteLine("It's last digit is six.");
                    break;
                case 7:
                    Console.WriteLine("It's last digit is seven.");
                    break;
                case 8:
                    Console.WriteLine("It's last digit is eight.");
                    break;
                case 9:
                    Console.WriteLine("It's last digit is nine.");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Write an integer: ");
            int num = int.Parse(Console.ReadLine());
            ReturnsLastDigitAsWord(num);

        }
    }
}
