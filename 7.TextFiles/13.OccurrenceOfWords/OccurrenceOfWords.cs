//Write a program that reads a list of words from a file words.txt and finds how many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

    class OccurrenceOfWords
    {
        static void Main()
        {
            List<string> resultWords = new List<string>();
            List<int> resultCount = new List<int>();
            StreamReader text = new StreamReader("test.txt");
            using (text)
            {
                try
                {
                    string line = "";
                    string word = "";
                    int index = 0;

                    StreamReader words = new StreamReader("words.txt");
                    using (words)
                    {
                        for (word = words.ReadLine(); word != null; word = words.ReadLine())
                        {
                            resultWords.Add(word);
                        }
                        for (int i = 0; i < resultWords.Count; i++)
                        {
                            resultCount.Add(0);
                        }
                        for (line = text.ReadLine(); line != null; line = text.ReadLine())
                        {
                            string[] wordsInLine = line.Split(' ');
                            for (int i = 0; i < resultWords.Count; i++)
                            {
                                for (int k = 0; k < wordsInLine.Length; k++)
                                {
                                    if (wordsInLine[k] != "I")
                                    {
                                        if (resultWords[i] == wordsInLine[k].ToLower())
                                        {
                                            resultCount[i]++;
                                        }
                                    }
                                    else
                                    {
                                        if (resultWords[i] == wordsInLine[k])
                                        {
                                            resultCount[i]++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    StreamWriter result = new StreamWriter("result.txt");
                    using (result)
                    {
                        int lineNumber = resultWords.Count;
                        int max = 0;

                        while (resultCount.Count > 0)
                        {
                            max = 0;
                            for (int i = 0; i < resultCount.Count; i++)
                            {
                                if (max < resultCount[i])
                                {
                                    max = resultCount[i];
                                }
                            }
                            for (int i = 0; i < resultCount.Count; i++)
                            {
                                if (resultCount[i] == max)
                                {
                                    result.WriteLine("{0} --> {1} times", resultWords[i], resultCount[i]);
                                    resultCount.RemoveAt(i);
                                    resultWords.RemoveAt(i);
                                    break;
                                }
                            }
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Missing file!");
                }
                catch (IOException)
                {
                    Console.WriteLine("Fatal error!");
                }
            }
        }
    }

