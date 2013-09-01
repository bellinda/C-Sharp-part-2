//We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that replaces the forbidden words with asterisks.
//Example: "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR."
//Words: "PHP, CLR, Microsoft"
//The expected result: "******** announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***."

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class ReplaceForbiddenWords
    {
        static void Main()
        {
            Console.WriteLine("Enter the list of forbidden words:");
            string forbiddenWords = Console.ReadLine();
            string[] forbidden = forbiddenWords.Split(',');
            for (int i = 0; i < forbidden.Length; i++)
            {
                forbidden[i] = forbidden[i].Trim();
            }
            Console.WriteLine("Enter the original text:");
            string text = Console.ReadLine();
            string[] wordsInText = text.Split(' ');
            StringBuilder stars = new StringBuilder();

            Console.WriteLine();
            Console.WriteLine("The result without the forbidden words: ");
            for (int i = 0; i < wordsInText.Length; i++)
            {
                if (forbidden.Contains(wordsInText[i].TrimEnd('.')))
                {
                    if (wordsInText[i].TrimEnd('.').Length != wordsInText[i].Length)
                    {
                        int starCount = wordsInText[i].Length - 1;
                        while (starCount > 0)
                        {
                            stars.Append("*");
                            starCount--;
                        }
                        stars.Append(".");
                        wordsInText[i] = stars.ToString();
                        stars.Clear();
                    }
                    else
                    {
                        int starCount = wordsInText[i].Length;
                        while (starCount > 0)
                        {
                            stars.Append("*");
                            starCount--;
                        }
                        wordsInText[i] = stars.ToString();
                        stars.Clear();
                    }
                }
                Console.Write(wordsInText[i] + " ");
            }
            Console.WriteLine();
        }
    }
