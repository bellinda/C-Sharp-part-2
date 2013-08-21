//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are 
//different. Assume the files have equal number of lines.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
    class CompareFiles
    {
        static void Main()
        {
            StreamReader file1 = new StreamReader("file1.txt");
            using (file1)
            {
                StreamReader file2 = new StreamReader("file2.txt");
                using (file2)
                {
                    try
                    {
                        int samelLines = 0;
                        int diffLines = 0;
                        string line1 = file1.ReadLine();
                        string line2 = file2.ReadLine();
                        while (line1 != null)
                        {
                            if (line1 == line2)
                            {
                                samelLines++;
                            }
                            else
                            {
                                diffLines++;
                            }
                            line1 = file1.ReadLine();
                            line2 = file2.ReadLine();
                        }
                        Console.WriteLine("Same lines = {0}, different lines = {1}", samelLines, diffLines);
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine("Missing file!");
                    }
                }
            }
        }
    }
