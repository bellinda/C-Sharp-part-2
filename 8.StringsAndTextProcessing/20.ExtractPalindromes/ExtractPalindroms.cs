//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class ExtractPalindroms
    {
        static void Main()
        {
            StringBuilder beforeMiddle = new StringBuilder();
            StringBuilder afterMiddle = new StringBuilder();
            Console.WriteLine("Enter a text:");
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToLower().TrimEnd(',', '!', '.', '?', '-');
            }
            Console.WriteLine();
            Console.WriteLine("Palindrome:");
            for (int i = 0; i < words.Length; i++)
            {
                int halfLength = words[i].Length / 2;
                if (words[i].Length % 2 == 0)
                {
                    for (int k = 0; k < halfLength; k++)
                    {
                        beforeMiddle.Append(words[i][k]);
                    }
                    for (int k = words[i].Length - 1; k >= halfLength; k--)
                    {
                        afterMiddle.Append(words[i][k]);
                    }
                }
                else
                {
                    for (int k = 0; k < halfLength; k++)
                    {
                        beforeMiddle.Append(words[i][k]);
                    }
                    for (int k = words[i].Length - 1; k > halfLength; k--)
                    {
                        afterMiddle.Append(words[i][k]);
                    }
                }
                if (beforeMiddle.ToString() == afterMiddle.ToString())
                {
                    Console.WriteLine(words[i]);
                }
                beforeMiddle.Clear();
                afterMiddle.Clear();
                
            }
        }
    }
