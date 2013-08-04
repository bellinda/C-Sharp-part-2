using System;
using System.Collections.Generic;
    class PrimeNumbers
    {
        static void Main()
        {
            List<int> allNumbers = new List<int>();
            int j = 3;
            Console.WriteLine("Please wait a minute for the result or reduce the range of the numbers!");
            while (j <= 1000000)
            {
                allNumbers.Add(j);
                j++;
            }
            List<int> primes = new List<int>();
            primes.Add(2);
            for (int i = 0; i < allNumbers.Count; i++)
            {
                for (int k = 0; k < primes.Count; k++)
                {
                    if (allNumbers[i] % primes[k] == 0)    //zanulqvane na elementite, koito se delqt na pone edno prosto
                    {
                        allNumbers[i] = 0;
                        break;
                    }
                    if ((k == primes.Count - 1) && (allNumbers[i] % primes[k] != 0))
                    {
                        primes.Add(allNumbers[i]);                                  //dobavqne na chislo kym spisyka s prostite
                        break;
                    }
                }
            }
            foreach (int element in allNumbers)
            {
                if (element != 0)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
