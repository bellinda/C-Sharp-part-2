//Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;
    class HexadecimalToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Write the number in its hexadecimal representation: ");
            string number = Console.ReadLine();
            int decimalNum = 0;
            int length = number.Length;
            int n = 0;
            for (int i = length - 1; i >= 0; i--)
            {
                if (number[i] > 57)
                {
                    char digit = number[i];
                    switch (digit)
                    {
                        case 'A':
                            {
                                decimalNum += 10 * (int)Math.Pow(16, n);
                                break;
                            }
                        case 'B':
                            {
                                decimalNum += 11 * (int)Math.Pow(16, n);
                                break;
                            }
                        case 'C':
                            {
                                decimalNum += 12 * (int)Math.Pow(16, n);
                                break;
                            }
                        case 'D':
                            {
                                decimalNum += 13 * (int)Math.Pow(16, n);
                                break;
                            }
                        case 'E':
                            {
                                decimalNum += 14 * (int)Math.Pow(16, n);
                                break;
                            }
                        case 'F':
                            {
                                decimalNum += 15 * (int)Math.Pow(16, n);
                                break;
                            }
                    }
                }
                else
                {
                    char digit = number[i];
                    switch (digit)
                    {
                        case '1':
                            {
                                decimalNum += 1 * (int)Math.Pow(16, n);
                                break;
                            }
                        case '2':
                            {
                                decimalNum += 2 * (int)Math.Pow(16, n);
                                break;
                            }
                        case '3':
                            {
                                decimalNum += 3 * (int)Math.Pow(16, n);
                                break;
                            }
                        case '4':
                            {
                                decimalNum += 4 * (int)Math.Pow(16, n);
                                break;
                            }
                        case '5':
                            {
                                decimalNum += 5 * (int)Math.Pow(16, n);
                                break;
                            }
                        case '6':
                            {
                                decimalNum += 6 * (int)Math.Pow(16, n);
                                break;
                            }
                        case '7':
                            {
                                decimalNum += 7 * (int)Math.Pow(16, n);
                                break;
                            }
                        case '8':
                            {
                                decimalNum += 8 * (int)Math.Pow(16, n);
                                break;
                            }
                        case '9':
                            {
                                decimalNum += 9 * (int)Math.Pow(16, n);
                                break;
                            }
                    }
                    
                }
                n++;
            }
            Console.WriteLine("Decimal representation: {0}", decimalNum);
        }
    }
