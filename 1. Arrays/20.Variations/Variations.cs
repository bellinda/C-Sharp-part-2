using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class VariationGenerator
{
    static void Variations(int index, int[] vector, int endNum)
    {
        if (index == -1)
        {
            Print(vector);
        }
        else
        {
            for (int i = 1; i <= endNum; i++)
            {
                vector[index] = i;
                Variations(index - 1, vector, endNum);
            }
        }
    }

    static void Print(int[] vector)
    {
        foreach (int i in vector)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("k = ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("n = ");
        int endNum = int.Parse(Console.ReadLine());

        int[] vector = new int[number];

        Variations(number - 1, vector, endNum);
    }
}