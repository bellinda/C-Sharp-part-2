//Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
    class InsertLineNumberInAFile
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("textFile.txt", Encoding.GetEncoding("windows-1251"));
            using (reader)
            {
                StreamWriter writer = new StreamWriter("new.txt", false, Encoding.GetEncoding("windows-1251"));
                using (writer)
                {
                    try
                    {
                        int lineNumber = 1;
                        string line = reader.ReadLine();
                        while (line != null)
                        {
                            writer.WriteLine("Line {0}:      {1}", lineNumber, line);
                            line = reader.ReadLine();
                            lineNumber++;
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine("Missing file!");
                    }
                }
            }
        }
    }
