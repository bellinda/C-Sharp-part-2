//Write program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter a binary number digit after digit. For END enter a digit different from 1 or 0 ");

            List<int> binNum = new List<int>();
            int temp;
            do
            {
                temp = int.Parse(Console.ReadLine());
                if (temp == 0 || temp == 1)
                {
                    binNum.Add(temp);
                }
            }
            while (temp == 0 || temp == 1);
            //we already have the digits of the binary number

            int decNum = 0;
            int n = 0;
            for (int i = binNum.Count - 1; i >= 0; i--)  //we are starting from the biggest index and go back to the nullable index (the biggest index is of the last digit in the number, so we should give it the smallest power)
            {
                decNum += binNum[i] * (int)Math.Pow(2, n);
                n++;
            }

            Console.WriteLine("The decimal representation of this binary number is {0}", decNum);

        }
    }

