using System;
using System.Collections.Generic;
    class SubsetSums
    {
        static void Main()
        {
            Console.Write("S = ");
            int wantedSum = int.Parse(Console.ReadLine());
            Console.Write("Number of elements in the array = ");
            byte n = byte.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            List<int> sums = new List<int>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0, len = sums.Count; j < len; j++)    // ako ne zapazim daljinata, koqto imame predi zapochvaneto na cikyla, 
                {                                                 //stigame do bezkraen cikyl i zapylvane na zadelenata pamet;
                    sums.Add(sums[j] + numbers[i]);              //za vsichki sumi do momenta dobavqme tekushtoto chislo
                }
                sums.Add(numbers[i]);
            }

            bool check = false;
            for (int i = 0; i < sums.Count; i++)
            {
                if (sums[i] == wantedSum)
                {
                    check = true;
                    break;
                }
            }
            if (check == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
