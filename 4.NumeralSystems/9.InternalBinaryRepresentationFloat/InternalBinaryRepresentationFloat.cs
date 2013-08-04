//*Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float).
//Example: -27,25 -> sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

using System;
using System.Collections.Generic;
    class InternalBinaryRepresentationFloat
    {
        static void Main()
        {
            Console.WriteLine("Enter the floating-point number: ");
            float number = float.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.Write("Sign = 1, ");
            }
            else
            {
                Console.Write("Sign = 0, ");
            }
            string digits = number.ToString();
            List<char> symbols = new List<char>();
            for (int i = 1; i < digits.Length; i++)
            {
                symbols.Add(digits[i]);
            }
            int n = 0;  //helping counter
            int counter = 0;  //counter for the digits before the floating point
            while(symbols[n] != 46)   //code of '.' in the ASCII table -> 46
            {
                counter++;
                n++;
            }
            int firstPart = 127 + (int)Math.Pow(2,counter);

            List<int> exponent = new List<int>();
            while (firstPart > 0)
            {
                exponent.Add(firstPart % 2);
                firstPart /= 2;
            }
            while (exponent.Count < 8)
            {
                exponent.Add(0);
            }
            //printing the exponent:
            Console.Write("exponent = ");
            for (int i = exponent.Count - 1; i >= 0; i--)
            {
                Console.Write(exponent[i]);
            }

            //representing the mantissa of the number

            int p = 0;
            int beforePoint = 0;
            for (int i = counter - 1; i >= 0; i--)
            {
                beforePoint += (symbols[i] - 48) * (int)Math.Pow(10, p);
                p++;
            }
            List<int> mantissa = new List<int>();
            while (beforePoint > 0)
            {
                mantissa.Add(beforePoint % 2);
                beforePoint /= 2;
            }
            mantissa.RemoveAt(mantissa.Count - 1);
            mantissa.Reverse();

            int counterAfterPoint = symbols.Count - counter - 1;   // -1 is for the floating point
            int afterPoint = 0;
            for (int i = counter + 1; i < symbols.Count; i++)
            {
                afterPoint += (symbols[i] - 48) * (int)Math.Pow(10, (symbols.Count - i - 1));
            }
            while ((afterPoint % (int)Math.Pow(10, counterAfterPoint) != 0) && (mantissa.Count < 23))
            {
                afterPoint *= 2;
                if(afterPoint / (int)Math.Pow(10,counterAfterPoint) >= 1)
                {
                    mantissa.Add(1);
                }
                else
                {
                    mantissa.Add(0);
                }
            }
            while (mantissa.Count < 23)
            {
                mantissa.Add(0);
            }
            Console.Write(", mantissa = ");
            for (int i = 0; i < mantissa.Count; i++)
            {
                Console.Write(mantissa[i]);
            }
            Console.WriteLine();
        }
    }
