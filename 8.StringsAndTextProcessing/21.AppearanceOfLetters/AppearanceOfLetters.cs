//Write a program that reads a string from the console and prints all different letters in the string along with information how many times 
//each letter is found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class AppearanceOfLetters
    {
        static void Main()
        {
            List<char> letters = new List<char>();
            Console.WriteLine("Enter your string:");
            string input = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                if (!letters.Contains(current))
                {
                    letters.Add(current);
                    Console.Write(current);
                    for (int k = 0; k < input.Length; k++)
                    {
                        if (input[k] == current)
                        {
                            counter++;
                        }
                    }
                    Console.WriteLine(" -> {0} time(s)", counter);
                }
                counter = 0;
            }

        }
    }
