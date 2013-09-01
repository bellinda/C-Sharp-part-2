//Write a program that reverses the words in given sentence.
//Example: "C# is not C++, not PHP and not Delphi!" --> "Delphi not and PHP, not C++ not is C#!" (the punctuation marks don't change their positions)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class ReverseWords
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();
            StringBuilder reversed = new StringBuilder();
            List<int> comaPositions = new List<int>();
            char lastChar = sentence[sentence.Length - 1];
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Trim(',').Length != words[i].Length)
                {
                    comaPositions.Add(i + 1);   //the coma should be on position i + 1 in the reversed string, too
                    words[i] = words[i].Trim(',');
                }
                if (i == words.Length - 1)
                {
                    words[i] = words[i].TrimEnd('.', '!', '?');
                }
            }
            int wordCounter = 0;
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversed.Append(words[i]);
                wordCounter++;
                if (comaPositions.Contains(wordCounter))
                {
                    reversed.Append(", ");
                }
                else
                {
                    reversed.Append(" ");
                }
            }
            reversed.Append("\b" + lastChar);
            Console.WriteLine(reversed);
        }
    }
