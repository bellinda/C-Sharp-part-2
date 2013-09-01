//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word 
//is found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class AppearanceOfWords
    {
        static void Main()
        {
            List<string> words = new List<string>();
            Console.WriteLine("Enter the string:");
            string inputText = Console.ReadLine();
            Console.WriteLine("First version with strings, lists and arrays:");
            Console.WriteLine();
            string[] separated = inputText.Split(' ');
            int counter = 0;
            for (int i = 0; i < separated.Length; i++)
            {
                separated[i] = separated[i].ToLower().Trim(',', '.', '!', '?', '\"');
            }
            for (int i = 0; i < separated.Length; i++)
            {
                if (!words.Contains(separated[i]))
                {
                    words.Add(separated[i]);
                    Console.Write(separated[i]);
                    for (int k = 0; k < separated.Length; k++)
                    {
                        if (separated[i] == separated[k])
                        {
                            counter++;
                        }
                    }
                    Console.WriteLine(" -> {0} time(s)", counter);
                }
                counter = 0;
            }

            Console.WriteLine();
            Console.WriteLine("Second version - with a dictionary: ");
            Console.WriteLine();

            //string text = "Do you know me, do you?";
            string[] input = inputText.Split(' ');
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].ToLower().Trim(',', '.', '?', '!');
            }
            Dictionary<string, int> wordsAtAll = new Dictionary<string, int>();
            foreach (string word in input)
            {
                if(!wordsAtAll.TryGetValue(word, out count))
                {
                    count = 0;
                }
                wordsAtAll[word] = ++count;
            }
            foreach (KeyValuePair<string, int> wordEntry in wordsAtAll)
            {
                Console.WriteLine("Word \"{0}\" --> {1} time(s)", wordEntry.Key, wordEntry.Value);
            }
        }
    }
