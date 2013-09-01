//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase.The tags cannot be nested.
//Example: "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else."
// The expected result: "We are living in a YELLOW SUBMARINE. We don't have ANYTHING else."

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    class TagsForUppercase
    {
        static void Main()
        {
            Console.WriteLine("Enter your text with the tags for uppercase");
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            StringBuilder word = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != '<')
                {
                    result.Append(text[i]);
                }
                else
                {
                    if (i + 1 == '/')
                    {
                        i += 9;
                    }
                    else
                    {
                        i += 8;
                        while (text[i] != '<')   //only the letters of the word, that should be with capital letters
                        {
                            word.Append(text[i]);
                            i++;
                        }
                        i += 8;                   // begin after the closing </upcase> tag
                        result.Append(word.ToString().ToUpper()); //adding the word(s) with the capital letters to the result
                        word.Clear();               //make the StringBuilder for the words with capital letters free
                    }
                }

            }
            Console.WriteLine(result);
        }
    }
