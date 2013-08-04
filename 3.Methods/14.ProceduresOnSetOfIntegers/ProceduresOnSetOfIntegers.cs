using System;
using System.Collections.Generic;
class ProceduresOnSetOfIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter the number of your integers:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter the integers:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The minimum of the given set of integers = {0}", FindMinimum(arr));
        Console.WriteLine("The maximum of the given set of integers = {0}", FindMaximum(arr));
        Console.WriteLine("Average of the given set of integers = {0}", FindAverage(arr));
        Console.WriteLine("Sum of the given integers = {0}", Sum(arr));
        Console.WriteLine("Product of the given integers = {0}", Multiplication(arr));

    }

    static int FindMinimum(int[] array)
    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    static int FindMaximum(int[] array)
    {
        int max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    static float FindAverage(int[] array)
    {
        float sum = (float)array[0];
        for (int i = 1; i < array.Length; i++)
        {
            sum += (float)array[i];
        }
        float average = sum / array.Length;
        return average;
    }

    static int Sum(int[] array)
    {
        int sum = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static int Multiplication(int[] array)
    {
        int multiply = 1;
        for (int i = 0; i < array.Length; i++)
        {
            multiply *= array[i];
        }
        return multiply;
    }
}

