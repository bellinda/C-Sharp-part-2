//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example: "aaaaabbbbbcdddeeeedssaa"  -> "abcdedsa"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class ReplaceIdenticalLetters
    {
        static void Main()
        {
            Console.WriteLine("Enter the string");
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder();
            output.Append(input[0]);                //adding the first letter as a begining
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    output.Append(input[i]);
                }
            }
            Console.WriteLine(output);
        }
    }
