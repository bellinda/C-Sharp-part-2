//Write a program that finds how many times a substring is contained in a given text(perform case insensitive search).
// Example: The target substring is "in". The text is as follows:
// "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."
// The result is: 9.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class ContainingOfSubstring
    {
        static void Main()
        {
            Console.WriteLine("Enter your text:");
            string text = Console.ReadLine();
            Console.WriteLine("Enter the substring you are searching for?");
            string search = Console.ReadLine();
            int counter = 0;
            int startIndex = 0;
            while (startIndex != - 1)
            {
                counter++;
                startIndex = text.IndexOf(search, startIndex + 1);

            }
            Console.WriteLine("It is contained {0} times.", counter);
        }
    }

