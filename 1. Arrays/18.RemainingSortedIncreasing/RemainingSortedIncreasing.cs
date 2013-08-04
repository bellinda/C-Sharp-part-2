//Write a program that reads an array of integers and removes from it a minimal number of elements in such way, that the remaining array is sorted 
//in increasing order. Print the remaining sorted array. Example: {6, 1, 4, 3, 0, 3, 6, 4, 5} -> {1, 3, 3, 4, 5} 

using System;
using System.Collections.Generic;
    class RemainingSortedIncreasing
    {
        static void Main()
        {
            Console.Write("How many numbers will you have in your array? ");
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            int temp;
            for (int i = 0; i < n; i++)
            {
                temp = int.Parse(Console.ReadLine());
                numbers.Add(temp);
            }
            int min = numbers[0];
            for (int i = 0; i < numbers.Count / 2 - 2; i++)
            {
                if (min > numbers[i + 1])
                {
                    min = numbers[i + 1];
                    numbers.RemoveAt(i);
                    i--;
                    numbers.Remove(min);
                    Console.Write(min + ", ");
                }
            }
            int lastMin = min;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int minNum = numbers[i];
                    
                if ((minNum > numbers[i + 1]) && (numbers[i + 1] > lastMin))
                {
                    minNum = numbers[i + 1];
                    numbers.RemoveAt(i);
                    i--;
                }
                if ((numbers[i + 1] <= min) && (minNum > numbers[i + 1]))
                {
                    numbers.RemoveAt(i + 1);
                    i--;
                }
                if (i > 0)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        numbers.RemoveAt(i + 1);
                        i--;
                    }
                }
                lastMin = minNum;
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i]);
                if (i != numbers.Count - 1)
                {
                    Console.Write(", ");
                }
            }
        }
    }
