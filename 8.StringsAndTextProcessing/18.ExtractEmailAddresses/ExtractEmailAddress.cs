//Write a program for extracting all email addresses from given text. All substrings that match the format <identifier>@<host>...<domain> 
//should be recognized as emails.
//Example text (from the book): Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.
//Result: example@abv.bg     baj.ivan@yahoo.co.uk 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

    class ExtractEmailAddress
    {
        static void Main()
        {
            Console.WriteLine("Enter the text:");
            string text = Console.ReadLine();
            string pattern = @"[A-Za-z_.*-0-9]{2,49}@\w{2,49}[.][A-Za-z_.-0-9]{2,49}";
            Match match = Regex.Match(text, pattern);
            while (match.Success)
            {
                Console.WriteLine(match);
                match = match.NextMatch();
            }
        }
    }