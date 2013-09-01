//Write a program that reads from theconsole a string of maximum 20 characters. If the legth of the string is less than 20,
//the rest of the charcters should be filled with '*'. Print the result string into the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class TwentyCharacters
    {
        static void Main()
        {
            Console.WriteLine("Enter a string with maximum length = 20 characters:");
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder(20);
            if (text.Length == 20)
            {
                Console.WriteLine(text);
            }
            else
            {
                result.Append(text);
                int starsCount = 0;
                while (starsCount + text.Length < 20)
                {
                    result.Append('*');
                    starsCount++;
                }
                Console.WriteLine(result);
            }
        }
    }
