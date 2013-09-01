//Write a program that extracts from a given text all sentences containing given word.
//Example: The word is "in". The text is:
//"We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."
//The expected result is: "We are living in a yeloww submarine. \n We will move out of it in 5 days."
//Concider that the sentences are separated by "." and the words - by non-letter symbols.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ExtractSentences
{
    static void Main()
    {
        Console.WriteLine("Enter your text:");
        string text = Console.ReadLine();
        Console.WriteLine("Which word are you looking for?");
        string word = Console.ReadLine();
        string[] sentences = text.Split('.');
        
        for (int i = 0; i < sentences.Length; i++) //every sentece
        {
            sentences[i] = sentences[i].Trim();
            string[] line = sentences[i].ToLower().Split(' '); //separating the words in every sentence
            if (line.Contains(word))
            {
                Console.WriteLine(sentences[i] + ".");
            }
        }
    }
}
