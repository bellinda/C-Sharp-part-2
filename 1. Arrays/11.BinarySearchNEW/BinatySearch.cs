using System;
using System.Collections.Generic;
    class BinarySearch
    {
        static void Main()
        {
            int k;
            int middle;
            int start = 0;
            Console.Write("How long will be your array? ");
            int n = int.Parse(Console.ReadLine());
            int end = n - 1;
            Console.WriteLine("Enter the numbers in it: ");
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                k = int.Parse(Console.ReadLine());
                numbers.Add(k);
            }
            numbers.Sort();
            Console.Write("The index of witch element are you searching for? ");
            int search = int.Parse(Console.ReadLine());
            while (start <= end)
            {
                middle = (start + end) / 2;                    //namirane vseki pyt na nova sredna stojnost, poradi stesnqvaneto na uchastaka, v kojto tyrsim chisloto
                if (search == numbers[middle])
                {
                    Console.WriteLine("Your index is {0}", middle);
                    break;
                }
                if(search > numbers[middle])                   //smalqvane na intervala, v kojto tyrsim
                {
                    start = middle + 1;
                }
                else if (search < numbers[middle])
                {
                    end = middle - 1;
                }
            }
        }
    }
