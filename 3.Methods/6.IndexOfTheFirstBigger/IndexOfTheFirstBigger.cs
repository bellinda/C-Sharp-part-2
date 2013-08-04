using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.IndexOfTheFirstBigger
{
    class IndexOfTheFirstBigger
    {
        static int GiveIndexOFTheFIrstBiggerThanTheNeighbours(int[] array)
        {
            for (int i = 1; i < (array.Length - 1); i++)
            {
                if(array[i] > array[i-1] && array[i] > array[i+1])
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("How long is your array? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter it's elements:");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int index = GiveIndexOFTheFIrstBiggerThanTheNeighbours(arr);
            Console.WriteLine("The index of the first element in the array that is bigger than it's neighbours is {0}.", index);
        }
    }
}
