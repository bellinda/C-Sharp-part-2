//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. 
//Format the output aligned right in 15 symbols.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class ChangeFormatOfInt
    {
        static void Main()
        {
            Console.WriteLine("Enter a floating point number");
            double number = double.Parse(Console.ReadLine());
            //another way to do the same: string s = number.ToString("P2");
            Console.WriteLine(String.Format("{0,15:P}", number) + "\t //percentage format");
            Console.WriteLine(String.Format("{0,15:E}", number) + "\t //scientific notation");
            Console.WriteLine("Enter an integer:");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("{0,15:X}", secondNumber) + "\t //hexadecimal format");
            Console.WriteLine(String.Format("{0,15:D}", secondNumber) + "\t //decimal format");
            Console.WriteLine(String.Format("{0,15:P}", secondNumber) + "\t //percentage format");
            Console.WriteLine(String.Format("{0,15:E}", secondNumber) + "\t //sScientific notation");
        }
    }
