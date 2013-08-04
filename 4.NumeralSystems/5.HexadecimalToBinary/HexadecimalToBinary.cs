//Write a program to convert hexadecimal numbers to binary numbers (directly). 

using System;
using System.Collections.Generic;
    class HexadecimalToBinary
    {
        static void Main()
        {
            //we should represent every single digit of the hexadecimal number in binary
            Console.WriteLine("Enter the hexadecimal number:");
            string hexNum = Console.ReadLine();
            int n = 0;
            int number;
            int counter = 0;
            List<int> binNum = new List<int>();
            for (int i = hexNum.Length - 1; i >= 0; i--)
            {
                counter = 0;
                if (hexNum[i] > 57)   //digits which are represented as letters
                {
                    char digit = hexNum[i];
                    switch (digit)
                    {
                        case 'A':
                            {
                                number = 10;
                                while (number > 0)
                                {
                                    binNum.Add(number % 2);
                                    number /= 2;
                                }
                                break;
                            }
                        case 'B':
                            {
                                number = 11;
                                while (number > 0)
                                {
                                    binNum.Add(number % 2);
                                    number /= 2;
                                }
                                break;
                            }
                        case 'C':
                            {
                                number = 12;
                                while (number > 0)
                                {
                                    binNum.Add(number % 2);
                                    number /= 2;
                                }
                                break;
                            }
                        case 'D':
                            {
                                number = 13;
                                while (number > 0)
                                {
                                    binNum.Add(number % 2);
                                    number /= 2;
                                }
                                break;
                            }
                        case 'E':
                            {
                                number = 14;
                                while (number > 0)
                                {
                                    binNum.Add(number % 2);
                                    number /= 2;
                                }
                                break;
                            }
                        case 'F':
                            {
                                number = 15;
                                while (number > 0)
                                {
                                    binNum.Add(number % 2);
                                    number /= 2;
                                }
                                break;
                            }
                    }
                }
                else if(hexNum[i] <= 57 && hexNum[i] > 48)   //digits between 1 and 9
                {
                    
                    number = hexNum[i] - 48;
                    while (number > 0)
                    {
                        binNum.Add(number % 2);
                        number /= 2;
                        counter++;
                    }
                    if (counter < 4)  //every digit should have 4 bits, so we add nulls at the beginning when the digits are < 4
                    {
                        while (counter < 4)
                        {
                            binNum.Add(0);
                            counter++;
                        }
                    }
                }
                else if (hexNum[i] == 48)   //in case the digits is 0
                {
                    for (int k = 0; k < 4; k++)
                    {
                        binNum.Add(0);
                    }
                }
            }

            for (int i = binNum.Count - 1; i >= 0; i--)
            {
                Console.Write(binNum[i]);
            }
        }
    }

