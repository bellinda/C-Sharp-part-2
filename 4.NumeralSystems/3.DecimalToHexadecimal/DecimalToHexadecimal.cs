//Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;
    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter the number you want to convert:");
            int number = int.Parse(Console.ReadLine());
            List<string> hex = new List<string>();
            
            while (number > 0)
            {
                int reminder = 0;
                reminder = number % 16;
                if (reminder > 9)
                {
                    switch (reminder)
                    {
                        case 10:
                            {
                                hex.Add("A");
                                break;
                            }
                        case 11:
                            {
                                hex.Add("B");
                                break;
                            }
                        case 12:
                            {
                                hex.Add("C");
                                break;
                            }
                        case 13:
                            {
                                hex.Add("D");
                                break;
                            }
                        case 14:
                            {
                                hex.Add("E");
                                break;
                            }
                        case 15:
                            {
                                hex.Add("F");
                                break;
                            }
                    }
                    number /= 16;
                }
                else
                {
                    hex.Add(reminder.ToString());
                    number /= 16;
                }
            }

            for (int i = hex.Count - 1; i >= 0; i--)
            {
                Console.Write(hex[i]);
            }
            Console.WriteLine();

        }
    }

