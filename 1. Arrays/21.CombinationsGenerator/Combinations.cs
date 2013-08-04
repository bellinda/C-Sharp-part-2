using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CombinationsGenerator
{
    static void Main()
    {
        Console.Write("K = "); //how many numbers will you have in every of your combinations
        int k = int.Parse(Console.ReadLine());
        int startNum = 1;
        Console.Write("N = ");   //from one to which number will be your combinations
        int endNum = int.Parse(Console.ReadLine());

        int[] arr = new int[k];
        GenerateCombinations(arr, 0, startNum, endNum);
    }

    static void GenerateCombinations(int[] arr, int index, int startNum, int endNum)
    {
        if (index >= arr.Length)
        {
            Console.WriteLine(String.Join(" ", arr));
        }
        else
        {
            for (int i = startNum; i <= endNum; i++)
            {
                arr[index] = i;
                GenerateCombinations(arr, index + 1, i + 1, endNum);
            }
        }
    }
}