using System;
using System.Collections.Generic;
    class Faktorial
    {
        static void Main()
        {
            int[] first = new int[300];
            int[] second = new int[300];
            int[] multiply = new int[300];
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int nCopy = n;//save it for later
            int nPrint = n; //to be printed on the console the first value of n
            
            //finding how many digits have the numbers that should be multiplyed
            int counterFirst = 0;
            while (n > 0)
            {
                n /= 10;
                counterFirst++;
            }
            n = nCopy;
            for (int i = 0; i < counterFirst; i++)
            {
                first[i] = n % 10;
                n /= 10;
            }
            n = nCopy;
            n--;
            nCopy--;
            int counterSecond = 0;
            while (n > 0)
            {
                n /= 10;
                counterSecond++;
            }
            n = nCopy;
            for (int i = 0; i < counterSecond; i++)
            {
                second[i] = n % 10;
                n /= 10;
            }
            n = nCopy;
            n--;
            nCopy--;
            multiply = Multiply(first, second);


            while (n > 0)
            {
                first = multiply; //save it for later
                //finding how many digits have the numbers that should be multiplyed
                //counterFirst = first.Length;
                counterSecond = 0;
                while (n > 0)
                {
                    n /= 10;
                    counterSecond++;
                }
                n = nCopy;
                for (int i = 0; i < counterSecond; i++)
                {
                    second[i] = n % 10;
                    n /= 10;
                }
                if (counterSecond == 1)
                {
                    for (int i = 1; i < second.Length; i++)
                    {
                        second[i] = 0;
                    }
                }
                n = nCopy;
                n--;
                nCopy--;
                multiply = Multiply(first, second);
            }

            Console.Write("{0}! = ", nPrint);
            for (int i = multiply.Length - 1; i >= 0; i--)
            {
                if (nPrint != 100)
                {
                    if ((Console.CursorLeft == 6) && (multiply[i] == 0))    //don't print the nulls at the beginning
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write(multiply[i]);
                    }
                }
                else
                {
                    if ((Console.CursorLeft == 7) && (multiply[i] == 0))    //don't print the nulls at the beginning
                    {
                        Console.Write("");
                    }
                    else
                    {
                        Console.Write(multiply[i]);
                    }
                }
            }
        }

        static int[] Multiply(int[] first, int[] second)
        {
            int[] newArrFirst = new int[300];
            int[] newArrSecond = new int[300];
            int[] result = new int[300];
            for (int i = 0; i < second.Length; i++)
            {
                int n = 0;
                for (int j = 0; j < first.Length; j++)
                {
                    if ((i == 0) && (n != 299))
                    {
                        newArrFirst[n] += (first[j] * second[i]) % 10;
                        newArrFirst[n + 1] += (first[j] * second[i]) / 10;
                    }
                    else
                    {
                        newArrSecond[n] += (first[j] * second[i]) % 10;
                        if (n != 299)
                        {
                            newArrSecond[n + 1] += (first[j] * second[i]) / 10;
                        }
                    }
                    n++;
                }
            }
            for(int i = 0; i < newArrFirst.Length; i++)
            {
                if (newArrFirst[i] > 9)
                {
                    newArrFirst[i + 1] += newArrFirst[i] / 10;
                    newArrFirst[i] = newArrFirst[i] % 10;
                }
            }
            for (int i = 0; i < newArrSecond.Length; i++)
            {
                if (newArrSecond[i] > 9)
                {
                    newArrSecond[i + 1] += newArrSecond[i] / 10;
                    newArrSecond[i] = newArrSecond[i] % 10;
                }
            }
            result[0] += newArrFirst[0];
            int k = 1;
            for (int i = 1; i < newArrFirst.Length; i++)
            {
                result[k] += newArrFirst[i] + newArrSecond[i-1];
                k++;
            }
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] > 9)
                {
                    result[i + 1] += result[i] / 10;
                    result[i] = result[i] % 10;
                }
            }
            return result;
        }
    }
