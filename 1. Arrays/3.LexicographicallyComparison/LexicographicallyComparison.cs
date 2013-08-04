using System;
    class LexicographicallyComparison
    {
        static void Main()
        {
            Console.Write("Lenght of the first array = ");
            int n = int.Parse(Console.ReadLine());
            char[] first = new char[n];
            Console.WriteLine("Elements in the first array: ");
            for (int i = 0; i < n; i++)
            {
                first[i] = char.Parse(Console.ReadLine());
            }
            Console.Write("Lenght of the second array = ");
            int m = int.Parse(Console.ReadLine());
            char[] second = new char[m];
            Console.WriteLine("Elements of the second array: ");
            for (int i = 0; i < m; i++)
            {
                second[i] = char.Parse(Console.ReadLine());
            }
            bool result = true;
            if (n == m)
            {
                for (int i = 0; i < n; i++)
                {
                    if (first[i] != second[i])
                    {
                        result = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("The arrays are lexicographically uncomparebale, because their lenght is different.");
            }
            if (n == m)
            {
                Console.WriteLine("The char arrays are equal - {0}", result);
            }
        }
    }

