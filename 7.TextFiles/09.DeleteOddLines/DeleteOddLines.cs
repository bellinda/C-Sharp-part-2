using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

    class DeleteOddLines
    {
        static void Main()
        {
            List<string> oddLines = new List<string>();
            List<string> evenLines = new List<string>();
            StreamReader file = new StreamReader("file.txt");
            using (file)
            {
                try
                {
                    string line = file.ReadLine();
                    int lineNum = 1;
                    while (line != null)
                    {
                        if (lineNum % 2 != 0)
                        {
                            oddLines.Add(line);
                        }
                        else
                        {
                            evenLines.Add(line);
                        }
                        line = file.ReadLine();
                        lineNum++;
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Input file is missing!");
                }
                catch (DirectoryNotFoundException)
                {
                    Console.WriteLine("Directory not found!");
                }
            }

            StreamWriter output = new StreamWriter("file.txt");
            using (output)
            {
                int counter = oddLines.Count + evenLines.Count;
                int start = 0;
                while (start < evenLines.Count)
                {
                    output.WriteLine(evenLines[start]);
                    start++;
                }
            }
        }
    }
