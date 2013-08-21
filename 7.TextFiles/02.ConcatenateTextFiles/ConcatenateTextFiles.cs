//Write a program that concatenates two text files into another text file.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
    class ConcatenateTextFiles
    {
        static void Main()
        {
            StreamReader text1 = new StreamReader("text1.txt");
            using (text1)
            {
                StreamReader text2 = new StreamReader("text2.txt");
                using (text2)
                {
                    StreamWriter concat = new StreamWriter("concatenated.txt");
                    using (concat)
                    {
                        try
                        {
                            string line = text1.ReadLine();
                            while (line != null)
                            {
                                concat.WriteLine(line);
                                line = text1.ReadLine();
                            }
                            line = text2.ReadLine();
                            while (line != null)
                            {
                                concat.WriteLine(line);
                                line = text2.ReadLine();
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
    }