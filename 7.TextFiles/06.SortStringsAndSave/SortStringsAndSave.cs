//Write a program that reads a text file containing a list of strings , sorts them and saves them to another text file. Example:
//  Ivan                Georgi
//  Petar               Ivan
//  Maria   ------->    Maria
//  Georgi              Petar

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
    class SortStringsAndSave
    {
        static void Main()
        {
            StreamReader input = new StreamReader("ToBeSorted.txt");
            using (input)
            {
                StreamWriter output = new StreamWriter("Sorted.txt");
                using (output)
                {
                    try
                    {
                        string line = input.ReadLine();
                        List<string> names = new List<string>();
                        while (line != null)
                        {
                            names.Add(line);
                            line = input.ReadLine();
                        }
                        names.Sort();
                        for (int i = 0; i < names.Count; i++)
                        {
                            output.WriteLine(names[i]);
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        output.WriteLine("Input file is missing!");
                    }
                    catch(IOException)
                    {
                        output.WriteLine("Fatal error!");
                    }
                }
            }
        }
    }
