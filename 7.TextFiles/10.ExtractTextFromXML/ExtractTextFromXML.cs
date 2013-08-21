//Write a program that extracts from given XML file all the text without the tags. Example:
//<?xml version="1.0"><student><name>PESHO</name><age>21</age><interests count="3"><interest>GAMES</interest><interest>C#</instrest><interest>
//JAVA</instrest></interests></student>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

    class ExtractTextFromXML
    {
        static void Main()
        {
            //creating an XML file using C#
            XmlDocument file = new XmlDocument();
            file.LoadXml("<student><name>Pesho</name><age>21</age><interests count=\"3\"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>");
            XmlTextWriter writer = new XmlTextWriter("file.xml", null);
            writer.Formatting = Formatting.Indented;
            file.Save(writer);
            writer.Close();   //close the already saved file and just then use it as a stream reader


            StreamReader input = new StreamReader("file.xml");
            using (input)
            {
                try
                {
                    string line = input.ReadLine();
                    while (line != null)
                    {
                        for (int i = 0; i < line.Length - 1; i++)
                        {
                            if (line[i] == '>' && line[i + 1] != '<')
                            {
                                i++;
                                while (line[i] != '<')
                                {
                                    Console.Write(line[i]);
                                    i++;
                                    if (line[i] == '<')
                                    {
                                        Console.WriteLine();
                                    }
                                }
                            }
                        }

                        line = input.ReadLine();
                    }
                }

                catch (FileNotFoundException)
                {
                    Console.WriteLine("Input file is missing!");
                }
                catch (DirectoryNotFoundException)
                {
                    Console.WriteLine("Directory is not found!");
                }
                catch (IOException)
                {
                    Console.WriteLine("Fatal error!");
                }
            }
        }
    }
