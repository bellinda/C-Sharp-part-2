//Write a program that replaces in a HTML document given as string all the tags <a href="...">...</a> with correxponding tags [URL=...]...[/URL].
//Sample HTML fragment: "<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>"
//Result: "<p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. 
//Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class ReplaceTagsHTML
    {
        static void Main()
        {
            Console.WriteLine("Enter the HTML text:");
            string text = Console.ReadLine();
            StringBuilder replaced = new StringBuilder();
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i]=='<' && i < text.Length-2 && text[i+1]=='/' && text[i+2] == 'a')
                {
                    replaced.Append("[/URL]");
                        counter = 0;
                        i += 3;
                }
                else if ((text[i] != '<' && text[i]!= '>') || (i < text.Length - 1 && text[i] == '<' && text[i+1] != 'a')
                    || (i < text.Length - 1 && text[i] == '<' && text[i + 1] != '/' && counter == 2) || (text[i] == '>' && i != 0 && text[i - 1] != '\"'))
                {
                    replaced.Append(text[i]);
                }
                else if(text[i] == '<')
                {
                    counter++;
                    if (counter == 1)
                    {
                        replaced.Append("[URL=");
                        i += 8;
                    }
                }
                else if (text[i] == '>' && i != 0 && text[i-1] == '\"')
                {
                    replaced.Remove(replaced.Length - 1, 1);
                    replaced.Append("]");
                }
            }
            Console.WriteLine(replaced);
        }
    }
