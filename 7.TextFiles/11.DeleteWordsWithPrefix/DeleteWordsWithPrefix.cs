//Write a program that deletes from a text file all words that start with the prefix "test". Words contain only the symbols 0...9, a...z, A...Z, _.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

    class DeleteWordsWithPrefix
    {
        static void Main()
        {
            // \btest\w*
            List<string> notMatched = new List<string>();
            StreamReader input = new StreamReader("words.txt");
            using (input)
            {
                try
                {
                    string patter = @"\btest\w*";
                    string line = input.ReadLine();
                    Regex regex = new Regex(patter);
                    while (line != null)
                    {
                        Match match = regex.Match(line); //finding the matches
                        if (match.ToString() == "")
                        {
                            notMatched.Add(line);
                        }
                        line = input.ReadLine();
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Missing file!");
                }
                catch (DirectoryNotFoundException)
                {
                    Console.WriteLine("Wrong or missing directory!");
                }
            }

            StreamWriter output = new StreamWriter("words.txt");
            using (output)
            {
                for (int i = 0; i < notMatched.Count; i++)
                {
                    output.WriteLine(notMatched[i]);
                }
            }
        }
    }
