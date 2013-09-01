//A dictionary is stored as a sequence of text lines containing words and their explanations. Write a program that enters a word and translates it by usingthe dictionary.
//Sample dictionary: 
// .Net - platform for applications from Microsoft
// CLR - managed executionenvironment for .NET
// namespace - hierarchical organization of classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

    class TranslateUsingDictionary
    {
        static void Main()
        {
            List<string> dictionary = new List<string>();
            List<string> wordsFromDictionary = new List<string>();
            StringBuilder word = new StringBuilder();
            try
            {
                StreamReader dictionaryFile = new StreamReader("Dictionary.txt");
                using (dictionaryFile)
                {
                    //Another way: Console.WriteLine("Enter your dictionary in the following format --> \"[word] - [explanation]\". Enter (-1) for end");
                    string line = dictionaryFile.ReadLine();
                    while (line != null)            //Another way: while(line != " ") => filling the dictionary with words, -1 = end of the filling
                    {
                        dictionary.Add(line);
                        line = dictionaryFile.ReadLine();
                    }
                }
                for (int i = 0; i < dictionary.Count; i++)
                {
                    for (int k = 0; k < dictionary[i].Length; k++)
                    {
                        if (dictionary[i][k] != ' ')
                        {
                            word.Append(dictionary[i][k]);
                        }
                        else
                        {
                            wordsFromDictionary.Add(word.ToString());
                            dictionary[i] = dictionary[i].Substring(k + 3, dictionary[i].Length - k - 3);
                            word.Clear();
                            break;
                        }
                    }
                }
                Console.WriteLine("Enter a word you want to explain when it is in the dictionary.");
                Console.WriteLine("Enter (-1) for end");
                string newWord = Console.ReadLine();
                while (newWord != "-1")
                {
                    if (wordsFromDictionary.Contains(newWord))
                    {
                        int index = wordsFromDictionary.IndexOf(newWord);
                        Console.WriteLine("Explanation: {0}", dictionary[index]);
                    }
                    else
                    {
                        Console.WriteLine("The written word is not in the dictionary. Please enter a new one or (-1) for end.");
                    }
                    newWord = Console.ReadLine();
                }

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Dictionary file not found!");
            }
        }
        
    
    }
