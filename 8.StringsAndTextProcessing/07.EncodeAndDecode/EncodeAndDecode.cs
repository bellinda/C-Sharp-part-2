//Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters. 
//The encoding/decoding is done by performing XOR (exclusive or) operation over the forst letter of the string with the first letter of the string 
//with the first of the key, the second - with the second, etc. When the last key character is reached, the next is the first.
//Example from the book: text: "Nakov", cipher: "ab", example result: "\u002f\u0003\u000a\u000d\u0017"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class EncodeAndDecode
{
    static void Main()
    {
        //the algorithm exactly:
        //char a = 'N';
        //char b = 'a';
        //ushort first = (ushort)a;
        //ushort second = (ushort)b;
        //ushort result = (ushort)(first ^ second);
        //Console.WriteLine(@"\u{0:x4}", result);

        Console.WriteLine("Enter the string you want to encode:");
        string text = Console.ReadLine();
        Console.WriteLine("Enter the encryption key:");
        string cipher = Console.ReadLine();
        ushort textLetterCode = 0;
        ushort keyLetterCode = 0;
        ushort result = 0;
        int keyIndex = 0;
        for (int i = 0; i < text.Length; i++)
        {
            textLetterCode = (ushort)text[i];
            keyLetterCode = (ushort)cipher[keyIndex];
            result = (ushort)(textLetterCode ^ keyLetterCode);
            Console.Write(@"\u{0:x4}", result);
            keyIndex++;
            if (keyIndex == cipher.Length)
            {
                keyIndex = 0;
            }
        }
        Console.WriteLine();

    }
}
