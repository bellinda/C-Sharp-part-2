//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.
//Sample input: "Hi!"  ---> Expected output: "\u0048\u0069\u0021"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class ConvertStringToUnicodeSeq
    {
        static void Main()
        {
            Console.WriteLine("Enter the string that should be converted:");
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder(input.Length * 6);
            for (int i = 0; i < input.Length; i++)
            {
                output.Append(String.Format(@"\u{0:x4}", (ushort)input[i]));
            }
            Console.WriteLine(output);
        }
    }
