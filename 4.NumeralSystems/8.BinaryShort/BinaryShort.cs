//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short)

using System;
using System.Collections.Generic;
    class BinaryShort
    {
        static void Main()
        {
            Console.WriteLine("Enter your signed integer (type short): ");
            short number = short.Parse(Console.ReadLine());
            short inverse = number;
            if (number < 0)
            {
                inverse = (short)(-number);
            }
            
            List<int> digits = new List<int>();

            if (number < 0)
            {
                //1. Signed magnitude
                while (inverse > 0)
                {
                    digits.Add(inverse % 2);
                    inverse /= 2;
                }
                while (digits.Count < 16)
                {
                    digits.Add(0);
                }
                digits[15] = ~digits[15] * (-1);
                Console.WriteLine("In signed magnitude the binary representation of the number {0} is: ", number);
                for (int i = 15; i >= 0; i--)
                {
                    Console.Write(digits[i]);
                }
                Console.WriteLine();

                //2. one's complement
                Console.WriteLine("In one's complement the binary representation of the number {0} is: ", number);
                Console.Write("bit for the sign -> " + digits[15] + " ");
                for (int i = 14; i >= 0; i--)
                {
                    if (digits[i] == 0)
                    {
                        Console.Write(1);
                    }
                    else
                        Console.Write(0);
                }
                Console.WriteLine();

                //3. two's complement:
                Console.WriteLine("In two's complement the binary representation od the number {0} is:", number);
                Console.Write("bit for the sign -> " + digits[15] + " ");
                for (int i = 14; i > 0; i--)
                {
                    if (digits[i] == 0)
                    {
                        Console.Write(1);
                    }
                    else
                        Console.Write(0);
                }
                if (digits[0] == 0)   //if the last digit in the signed magnitude is 0, it should be one in the one's complement and again null in the two's complement
                {
                    Console.Write(0);
                }
                else
                    Console.Write(1);

                Console.WriteLine();
            }
            else   //if the number is positive
            {
                while (number > 0)
                {
                    digits.Add(number % 2);
                    number /= 2;
                }
                while (digits.Count < 16)
                {
                    digits.Add(0);
                }
                for (int i = digits.Count - 1; i >= 0; i--)
                {
                    Console.Write(digits[i]);
                }
                Console.WriteLine();
            }
        }
    }

