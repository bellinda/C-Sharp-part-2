//Write a method, that adds two polynomials. Represent them as arrays of their coefficients as in the example:
// x^2 + 5 = 1.x^2 + 0.x + 5    => 5(exponent null) 0(exponent one) 1(exponent two)

using System;
using System.Collections.Generic;
class AddingPolynoms
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
        Console.Write("Sum of the polynomials (represented as coefficients starting from the coefficient for the nullable exponent: ");
        result = AddPolynomials(first, second);
        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i] + " ");
        }
    }

    static List<int> AddPolynomials(List<int> first, List<int> second)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < first.Count; i++)
        {
            result.Add(first[i] + second[i]);
        }
        return result;
    }
}
