//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
    class BinaryToHexadecimal
    {
        static void Main()
        {
            // we should represent the number in groups of 4 bits, every four bits are one digit (or letter)
            Console.WriteLine("Enter the binary number:");
            string binary = Console.ReadLine();
            string temp = "";
            string hexDec = "";
            List<int> binNum = new List<int>();
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                binNum.Add(binary[i] - 48);
            }

            if (binNum.Count % 4 != 0)   //adding nulls at the beginning, do that we can represent the number in groups of 4 digits
            {
                while (binNum.Count % 4 != 0)
                {
                    binNum.Add(0);
                }
            }
            int count = binNum.Count;

            while (binNum.Count > 0)
            {
                temp = "";
                for (int i = 3; i >= 0; i--)
                {
                    temp += (binNum[i]);
                }
                switch (temp)
                {
                    case "0000":
                        {
                            hexDec += "0";
                            break;
                        }
                    case "0001":
                        {
                            hexDec += "1";
                            break;
                        }
                    case "0010":
                        {
                            hexDec += "2";
                            break;
                        }
                    case "0011":
                        {
                            hexDec += "3";
                            break;
                        }
                    case "0100":
                        {
                            hexDec += "4";
                            break;
                        }
                    case "0101":
                        {
                            hexDec += "5";
                            break;
                        }
                    case "0110":
                        {
                            hexDec += "6";
                            break;
                        }
                    case "0111":
                        {
                            hexDec += "7";
                            break;
                        }
                    case "1000":
                        {
                            hexDec += "8";
                            break;
                        }
                    case "1001":
                        {
                            hexDec += "9";
                            break;
                        }
                    case "1010":
                        {
                            hexDec += "A";
                            break;
                        }
                    case "1011":
                        {
                            hexDec += "B";
                            break;
                        }
                    case "1100":
                        {
                            hexDec += "C";
                            break;
                        }
                    case "1101":
                        {
                            hexDec += "D";
                            break;
                        }
                    case "1110":
                        {
                            hexDec += "E";
                            break;
                        }
                    case "1111":
                        {
                            hexDec += "F";
                            break;
                        }
                }
                for (int i = 0; i < 4; i++)
                {
                    binNum.RemoveAt(0);
                }
            }

            //printing the number in its hexadecimal representation
            for (int i = hexDec.Length - 1; i >= 0; i--)
            {
                Console.Write(hexDec[i]);
            }
            Console.WriteLine();
        }
    }
