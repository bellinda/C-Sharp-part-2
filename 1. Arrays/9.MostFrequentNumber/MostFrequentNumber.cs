using System;
    class MostFrequentNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of he digits in your array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int[] count = new int[n];
            int counter = 1;
            int maxcount = 0;
            int maxindex = 0;
            int number = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int k = 1;
            for (int i = 0; i < n-1; i++)
            {
                    do
                    {
                        if((array[i] == array[k])&&(k!=i))
                        {
                            counter++;
                        }
                        k++;
                    }
                    while(k<n);
                    k = 1;
                count[i] = counter;
                counter = 1;
            }
            for (int i = 0; i < n-1; i++)
            {
                if (maxcount < count[i])
                {
                    maxcount = count[i];
                    maxindex = i;
                    number = array[i];
                }
            }
            Console.WriteLine("The number {0} is the most frequent number with frequence = {1}.", number, maxcount);

        }
    }
