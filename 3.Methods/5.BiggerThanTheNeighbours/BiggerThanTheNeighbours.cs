using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.BiggerThanTheNeighbours
{
    class BiggerThanTheNeighbours
    {
        static bool IsBiggerThanTheNeighbours(int position, int[] array)
        {
            if (position == 0)
            {
                if (array[position] > array[position + 1])
                {
                    return true;
                }
                else
                    return false;
            }
            else
            {
                if (array[position] > array[position - 1] && array[position] > array[position + 1])
                {
                    return true;
                }
                else
                    return false;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("How many elements has your array? ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Which is the index of the element you want to check?");
            int index = int.Parse(Console.ReadLine());
            bool isBigger = IsBiggerThanTheNeighbours(index, arr);
            Console.WriteLine("The element with index {0} in your array is bigger than it's neighbours -> {1}.", index, isBigger);

        }
    }
}
