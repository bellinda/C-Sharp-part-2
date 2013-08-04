//Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;
    class DecimalToBinary
    {
        static void Main()
        {
            Console.Write("Enter the number you want to convert to its binary representation: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 0)
            {
                List<int> binary = new List<int>();   //I will save the digits of the binary number in a list
                while (number > 0)
                {
                    binary.Add(number % 2);
                    number /= 2;
                }
                for (int i = binary.Count - 1; i >= 0; i--)
                {
                    Console.Write(binary[i]);
                }
                Console.WriteLine();
            }
            else
            {
                //int num = -3;
                number = -number-1;
                List<int> binary = new List<int>();   //I will save the digits of the binary number in a list
                while (number > 0)
                {
                    binary.Add(number % 2);
                    number /= 2;
                }
                for (int i = 0; i < 3; i++)
                {
                    binary.Add(0);   //adding three more nulls at the beginning of the number
                }
                for (int i = binary.Count - 1; i >= 0; i--)
                {
                    if (binary[i] == 1)
                    {
                        Console.Write(0);
                    }
                    else
                    {
                        Console.Write(1);
                    }
                }
                Console.WriteLine();
            }
        }
    }

