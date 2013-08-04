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
                    //if (first[i] == second[i] && (i = n - 1))
                    //{
                        //Console.WriteLine("The arrays are equal.");
                    //}
                   // else if()

                   //result = first[i].Equals(second[i], StringComparison.Ordinal);

                    if (first[i] != second[i])
                    {
                        result = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("The arrays are lexicographically uncomparebale.");
            }
            Console.WriteLine("The arrays are equal - {0}", result);
        }
    }

