using System;
    class ReadAndCompare
    {
        static void Main()
        {
            Console.Write("Lenght of the first array = ");
            int n = int.Parse(Console.ReadLine());
            int [] first = new int [n];
            Console.WriteLine("Elements in the first array: ");
            for (int i = 0; i < n; i++)
            {
                first[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Lenght of the second array = ");
            int m = int.Parse(Console.ReadLine());
            int[] second = new int[m];
            Console.WriteLine("Elements of the second array: ");
            for (int i = 0; i < m; i++)
            {
                second[i] = int.Parse(Console.ReadLine());
            }
            int k=0;
            if (n == m)     //equal to first.Lenght == second.Lenght
            {
                while (k<n) 
                {
                    if (first[k] != second[k])
                    {
                        Console.WriteLine("The arrays are not equal.");
                        break;
                    }
                    if ((k == n-1) && (first[k] == second[k]))
                    {
                        Console.WriteLine("Both arrays are equal.");
                    }
                    k++;
                    if (k == n)
                    {
                        break;
                    }
                }
            }
                else
                {
                    Console.WriteLine("Both arrays have different lenght, so they are not equal.");
                }
        }
    }
