//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
//Ensure it will work with large files (e.g. 100MB).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

    class ReplaceOccurrencesInTextFile
    {
        static void Main()
        {
            StreamReader input = new StreamReader("text.txt");
            using (input)
            {
                StreamWriter output = new StreamWriter("textNew.txt");
                using (output)
                {

                    try
                    {
                        string line = input.ReadLine();
                        string replaced = "";
                        while (line != null)
                        {
                            if (line == line.ToLower())
                            {
                                replaced = line.Replace("start", "finish");
                                output.WriteLine(replaced);
                            }
                            else
                            {
                                replaced = line.Replace("Start", "Finish");
                                output.WriteLine(replaced);
                            }
                            line = input.ReadLine();
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine("Input file is missing!");
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("Fatal error!");
                    }
                }
            }
            File.Replace("textNew.txt", "text.txt", "backup.txt");
        }
    }
