//Write a program that removes from a text file all words listed in given another text file. Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

    class RemoveListedWords
    {
        static void Main()
        {
            List<string> stayingWords = new List<string>();
            StreamReader words = new StreamReader("words.txt");
            using (words)
            {
                try
                {
                    string lineW = ""; //a line from the file words.txt
                    string lineL = "";  //a line from the file list.txt
                    int counter = 0;
                    int numberOfLines = 0;
                    for (lineW = words.ReadLine(); lineW != null; lineW = words.ReadLine())
                    {
                        StreamReader list = new StreamReader("list.txt");
                        using (list)
                        {
                            for (lineL = list.ReadLine(); lineL != null; lineL = list.ReadLine())
                            {
                                numberOfLines++;
                                if (lineW != lineL)
                                {
                                    counter++;
                                }

                            }
                            if (numberOfLines == counter)
                            {

                                stayingWords.Add(lineW);
                                counter = 0;
                                numberOfLines = 0;
                            }
                        }

                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Missinf file!");
                }
                catch (DirectoryNotFoundException)
                {
                    Console.WriteLine("Wrong or missing directory of the fils!");
                }
                
            }
            StreamWriter write = new StreamWriter("words.txt");
            using (write)
            {
                for (int i = 0; i < stayingWords.Count; i++)
                {
                    write.WriteLine(stayingWords[i]);
                }
            }
        }
    }
