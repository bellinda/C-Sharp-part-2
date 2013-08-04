//Write a program that read a number N and generates and prints all the permutations of the numbers [1..N].
//Example: N=3 -> {1 2 3} {1 3 2} {2 1 3} {2 3 1} {3 1 2} {3 2 1}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class Permutation
{
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string numberAsWord = "";
            int helper = 1;
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = helper;
                helper++;
            }
            for (int i = 0; i < n; i++)
            {
                numberAsWord += numbers[i].ToString();
            }
            Permutation.permuteString(string.Empty, numberAsWord);
            Console.ReadLine();

        }

        public static void permuteString(string beginningString, string endingString)
        {

            if (endingString.Length <= 1)
                Console.WriteLine(beginningString + endingString);
            else
                for (int i = 0; i < endingString.Length; i++)
                {
                    string a = endingString.Substring(0, i);
                    string b = endingString.Substring(i + 1);
                    string newString = endingString.Substring(0, i) + endingString.Substring(i + 1);

                    permuteString(beginningString + endingString.ElementAt(i), newString);

                }
        }
    }
