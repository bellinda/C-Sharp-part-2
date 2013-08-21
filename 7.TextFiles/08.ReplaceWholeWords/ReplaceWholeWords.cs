//Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

    class ReplaceWholeWords
    {
        static void Main()
        {
            StreamReader input = new StreamReader("text1.txt");
            using (input)
            {
                StreamWriter output = new StreamWriter("text2.txt");
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
                                replaced = Regex.Replace(line, @"\bstart\b", "finish");
                                output.WriteLine(replaced);
                                line = input.ReadLine();
                            }
                            else
                            {
                                replaced = Regex.Replace(line, @"\bStart\b", "Finish");
                                output.WriteLine(replaced);
                                line = input.ReadLine();
                            }
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
            File.Replace("text2.txt", "text1.txt", "backup.txt");
        }
    }
