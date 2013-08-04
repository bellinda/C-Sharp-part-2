using System;
    class MaxConsistantlyGrowingSeq
    {
        static void Main()
        {
            int maxindex = 0;
            int maxcount = 0;
            int newlenght = 1;
            int k = 0;
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int[] count = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < (n - 1); i++)
            {
                k = i;
                while ((array[i] + 1 == array[i + 1])&&(i<(n-1)))
                {
                    newlenght++;
                    i++;
                    if (i >= n - 1)
                    {
                        break;
                    }
                }
                i = k+(newlenght-1);
                if (i != 0)
                {
                    count[i-1] = newlenght;           //za da moje da otchita pravilno, ako nai-dalgata poredica e v kraq na masiva
                }
                newlenght = 1;
             }
            for (int i = 0; i < (n - 1); i++)
            {
                if ((count[i] > count[i + 1]) && (count[i] > maxcount))
                {
                    maxcount = count[i];
                    maxindex = i;
                }
            }
            Console.WriteLine();
            Console.Write(maxcount + ": ");
            for (int i = maxcount-2; i >= -1; i--)
            {
                Console.Write(array[maxindex-i] + ", ");
            }
            Console.Write("\b");
            Console.Write("\b");
            Console.Write(" ");
        }
   }
