//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
//Example: <html><head><title>News</title></head><body><p><a href="http://academy.telerik.com">Telerik Academy</a>aims
//to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.
//</p></body></html>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class ExtractTextsHTML
    {
        static void Main()
        {
            Console.WriteLine("Enter the html file as a text:");
            string html = Console.ReadLine();
            StringBuilder output = new StringBuilder();
            bool space = false;
            for (int i = 0; i < html.Length; i++)
            {
                if (html[i] == '>' && i < html.Length - 1)
                {
                    i++;
                    while (html[i] != '<')
                    {
                        space = true;
                        output.Append(html[i]);
                        i++;
                    }
                    if (space == true)
                    {
                        output.Append("\n");
                        space = false;
                    }
                }
            }
            Console.WriteLine(output);
        }
    }
