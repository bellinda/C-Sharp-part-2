using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.IndexOfLetter
{
    class IndexOfLetter
    {
        static void Main()
        {
            char k;                               //vsqka bukva ot ASCII tablicata shte se zapazva v tazi promenliva, predi da byde vmyknat v spisaka
            List<char> chars = new List<char>();
            List<int> letters = new List<int>();
            for (int i = 65; i <= 90; i++)
            {
                k = (char)i;
                letters.Add(k);
            }
            for (int i = 97; i <= 122; i++)
            {
                k = (char)i;
                letters.Add(k);
            }
            Console.WriteLine("Give me a word: ");
            string word = Console.ReadLine();

            int middle;
            int start = 0;
            int end = letters.Count - 1;
            
            for (int i = 0; i < word.Length; i++)                //s dvoichno tyrsene proverqvame na koq poziciq e bukvata ot vavedenata ot nas duma v masiva s vsichki bukvi
            {
                while (start <= end)
                {
                middle = (start + end) / 2;
                if (word[i] == letters[middle])
                {
                    Console.WriteLine(middle);
                    break;
                }
                if (word[i] < letters[middle])
                {
                    end = middle - 1;
                }
                else if (word[i] > letters[middle])
                {
                    start = middle + 1;
                }
            }
                start = 0;
                end = letters.Count - 1;
        }

            
        }
    }
}
