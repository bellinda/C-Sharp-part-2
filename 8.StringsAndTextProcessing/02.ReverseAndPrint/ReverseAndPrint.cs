using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    class ReverseAndPrint
    {
        static void Main()
        {
            Console.WriteLine("Enter your string: ");
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder(input.Length);
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output.Append(input[i]);
            }
            Console.WriteLine(output);
        }
    }
