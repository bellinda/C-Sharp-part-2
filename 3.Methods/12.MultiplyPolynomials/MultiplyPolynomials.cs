using System;
using System.Collections.Generic;
class MultiplyPolynomials
{
    static void Main()
    {
        List<int> first = new List<int>();
        List<int> second = new List<int>();
        List<int> result = new List<int>();

        Console.Write("How many exponents have you got in the polynomials? ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the coefficients of the first polynomial starting from the coefficient for the nullable exponent:");
        for (int i = 0; i < n; i++)
        {
            int temp = int.Parse(Console.ReadLine());
            first.Add(temp);
        }
        Console.Write("Enter the coefficients of the second polynomial starting from the coefficient for the nullable exponent:");
        for (int i = 0; i < n; i++)
        {
            int temp = int.Parse(Console.ReadLine());
            second.Add(temp);
        }
        result = Multiply(first, second, n);
        Console.WriteLine("Result: ");
        for (int i = 0; i < result.Count - 1; i++)
        {
            Console.Write(result[i] + " ");
        }

    }

    static List<int> Multiply(List<int> first, List<int> second, int n)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < 2*(n-1) + 1; i++)
        {
            result.Add(0);
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i + j] += first[i] * second[j];
            }
        }
        return result;
    }
}
