//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
    class ReadAndPrintOddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("ToBeRead.txt");
            using (reader)
            {
                try
                {
                    int lineNumber = 1;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        if (lineNumber % 2 != 0)
                        {
                            Console.WriteLine("Line {0}:  {1}", lineNumber, line);
                        }
                        lineNumber++;
                        line = reader.ReadLine();
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("The file is missing!");
                }
            }
        }
    }
