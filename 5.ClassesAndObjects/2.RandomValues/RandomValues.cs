//2.Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;
using System.Collections.Generic;
    class RandomValues
    {
        static Random randomGenerator = new Random();
        static void Main()
        {
            //Random randomGenerator = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int random = randomGenerator.Next(100, 201);
                Console.WriteLine(random);
            }
        }
    }
