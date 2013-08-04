using System;
using System.Collections.Generic;
class GenericMethod
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
        Console.WriteLine("The minimum of the given set of integers = {0}",FindMinimum(ref arr));     
        Console.WriteLine("The maximum of the given set of integers = {0}", FindMaximum(ref arr));
        Console.WriteLine("Average of the given set of integers = {0}", FindAverage(ref arr));
        Console.WriteLine("Sum of the given integers = {0}", Sum(ref arr));
        Console.WriteLine("Product of the given integers = {0}", Multiplication(ref arr));
    }

    static T FindMinimum<T>( ref T[] array)
    {
        dynamic min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    static T FindMaximum<T>(ref T[] array)
    {
        dynamic max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    static T FindAverage<T>(ref T[] array)
    {
        dynamic sum = (dynamic)array[0];
        for (int i = 1; i < array.Length; i++)
        {
            sum += (dynamic)array[i];
        }
        dynamic average = sum / array.Length;
        return average;
    }

    static T Sum<T>(ref T[] array)
    {
        dynamic sum = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static T Multiplication<T>(ref T[] array)
    {
        dynamic multiply = 1;
        for (int i = 0; i < array.Length; i++)
        {
            multiply *= array[i];
        }
        return multiply;
    }
}
