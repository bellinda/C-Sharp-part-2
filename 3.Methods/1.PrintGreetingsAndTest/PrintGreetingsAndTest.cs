using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.PrintGreetingsAndTest
{
    class PrintGreetingsAndTest
    {
        static void PrintGreetings(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }

        static bool IsNameValid(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if ((name[i] <= (char)65) || (name[i] >= (char)90) || (name[i] <= (char)97) || (name[i] >= (char)122))
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("What's your name? ");
            string name = Console.ReadLine();
            if (IsNameValid(name))
            {
                PrintGreetings(name);
            }
            else
            {
                Console.WriteLine("Invalid name!");
            }
        }
    }
}
