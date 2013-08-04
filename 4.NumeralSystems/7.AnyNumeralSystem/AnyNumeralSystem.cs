//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2<=s, d<=16).

using System;
using System.Collections.Generic;
    class AnyNumeralSystem
    {
        static void Main()
        {
            Console.Write("s = ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("d = ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number with base s");
            int number = int.Parse(Console.ReadLine());
            List<string> digitsHex = new List<string>();
            int numberBase10 = 0;
            string numberBaseD = "";
            int n = 0;

            if(s != 2 && d != 16)
            {
                //1.convert from base s to base 10
                while (number > 0)
                {
                    numberBase10 += (number % 10) * (int)Math.Pow(s, n);
                    n++;
                    number /= 10;
                }

                //2.convert from base 10 to base d
                while (numberBase10 > 0)
                {
                    numberBaseD += numberBase10 % d;
                    numberBase10 /= d;
                }
                Console.Write("The number represented in a numeral system with base d: ");
                for (int i = numberBaseD.Length - 1; i >= 0; i--)
                {
                    Console.Write(numberBaseD[i]);
                }
                Console.WriteLine();
            }
            else if (d == 16)
            {
                //1.convert from base s to base 10
                while (number > 0)
                {
                    numberBase10 += (number % 10) * (int)Math.Pow(s, n);
                    n++;
                    number /= 10;
                }
                //2.convert from base 10 to base d=16
                while (numberBase10 > 0)
                {
                    int reminder = 0;
                    reminder = numberBase10 % 16;
                    if (reminder > 9)
                    {
                        switch (reminder)
                        {
                            case 10:
                                {
                                    digitsHex.Add("A");
                                    break;
                                }
                            case 11:
                                {
                                    digitsHex.Add("B");
                                    break;
                                }
                            case 12:
                                {
                                    digitsHex.Add("C");
                                    break;
                                }
                            case 13:
                                {
                                    digitsHex.Add("D");
                                    break;
                                }
                            case 14:
                                {
                                    digitsHex.Add("E");
                                    break;
                                }
                            case 15:
                                {
                                    digitsHex.Add("F");
                                    break;
                                }
                        }
                        numberBase10 /= 16;
                    }
                    else
                    {
                        digitsHex.Add(reminder.ToString());
                        numberBase10 /= 16;
                    }
                }

                Console.Write("The number represented in a numeral system with base d: ");
                for (int i = digitsHex.Count - 1; i >= 0; i--)
                {
                    Console.Write(digitsHex[i]);
                }
                Console.WriteLine();
            }
        }
    }

