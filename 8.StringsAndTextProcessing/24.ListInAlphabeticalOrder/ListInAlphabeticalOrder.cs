//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class ListInAlphabeticalOrder
    {
        static void Main()
        {
            Console.WriteLine("Enter a list of words, separated by spaces:");
            string input = Console.ReadLine();
            string[] list = input.Split(' ');
            List<string> words = list.ToList<string>();
            words.Sort();
            for (int i = 0; i < words.Count; i++)
            {
                Console.Write("{0} ", words[i]);
            }
            Console.WriteLine();
        }
    }
