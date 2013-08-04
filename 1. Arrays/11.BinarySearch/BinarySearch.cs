using System;
using System.Collections.Generic;
class BinarySearch
{
    static void Main()
        {
            int count = 0;
            int k;
            Console.Write("How long will be your array of numbers? ");
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                k = int.Parse(Console.ReadLine());
                numbers.Add(k);
            }
            numbers.Sort();
            Console.Write("Which number are you looking for? ");
            int search = int.Parse(Console.ReadLine());
            int firstCount = numbers.Count;
            int m = numbers.Count / 2;
            int middle = numbers[m];
            int middle2 = 1;
            do
            {
            if (search < numbers[numbers.Count / 2])
            {
                do
                {
                    count++;
                    int l = numbers.Count / 2;
                    if ((numbers.Count % 2 == 1) && (count != 1))
                    {
                        //count++;
                        for (int i = l; i <= (l * 2); i++)
                        {
                            k = numbers[l];
                            numbers.Remove(k);
                        }
                    }
                    //else if (count == 1)
                    //{
                    //    for (int i = l; i < (l * 2); i++)
                    //    {
                    //        k = numbers[l];
                    //        numbers.Remove(k);
                    //    }
                    //}
                    else
                    {
                        //count++;
                        for (int i = l; i < (l * 2); i++)
                        {
                            k = numbers[l];
                            numbers.Remove(k);
                        }
                    }
                }
                while (search < numbers[numbers.Count / 2]);  // &&(search != numbers[numbers.Count / 2])
                //Console.WriteLine("The element you are looking for is with index {0} in your array.", numbers.Count/2);
            }
            if(search > numbers[numbers.Count/2])    //else if
               {
                   do
                   {
                       count++;
                       int l = numbers.Count/2;
                       if (numbers.Count % 2 == 1)
                       {
                           for (int i = 0; i <= l; i++)
                           {
                               k = numbers[0];
                               numbers.Remove(k);
                           }
                           if (count != 1)
                           {
                               middle2++;
                           }
                       }
                       else
                       {
                           if (l == 2)
                           {
                               for (int i = 0; i < l-1; i++)
                               {
                                   k = numbers[0];
                                   numbers.Remove(k);
                               }
                           }
                           else
                           {
                               for (int i = 0; i < l; i++)
                               {
                                   k = numbers[0];
                                   numbers.Remove(k);
                               }
                           }
                       }
                   }
                   while ((search != numbers[numbers.Count / 2])&&(search > numbers[numbers.Count/2]));

        
                   
               }
            }
            while (search != numbers[numbers.Count / 2]);
            if (search == middle)
            {
                Console.WriteLine("The element you are looking for is with index {0} in your array.", m);
            }
           if ((search == numbers[(numbers.Count / 2)]) && (numbers.Count != 2) && (search > middle) && (numbers.Count != 1))     //else if
                {
                    count++;
                    Console.WriteLine("The element you are looking for is with index {0} in your array.", m + count + 1);        //numbers.Count/2
                }
           if ((search < middle) && (search == numbers[(numbers.Count / 2)]) && (numbers.Count != 2) && (numbers.Count != 1))
           {
               count++;
               Console.WriteLine("The element you are looking for is with index {0} in your arrau=y.", m-count+1);
           }
  
            //if (count != 0)
            //{
            //    if (count == 1)
            //    {
            //        Console.WriteLine("The element you are looking for is with index {0} in your array.", (m + m / 2));
            //    }
           if ((search == numbers[(numbers.Count / 2)]) && (numbers.Count == 2) && (search < middle))
           {
               Console.WriteLine("The element you are looking for is with index {0} in your array.", m - count);
           }
            if((search==numbers[(numbers.Count/2)])&&(numbers.Count==2)&&(search > middle) && (middle2 == 1))
            {
                Console.WriteLine("The element you are looking for is with index {0} in your array.", m + count);
            }
            if ((search == numbers[(numbers.Count / 2)]) && (numbers.Count == 2) && (search > middle) && (middle2 > 2))
            {
                Console.WriteLine("The element you are looking for is with index {0} in your array.", m + count + 1);
            }
            //if ((search > m) && (numbers.Count==2))      //(count % 2 == 1) && (count != 1) && 
            //{
            //    Console.WriteLine("The element you are looking for is with index {0} in your array.", (m + count));    //(count * 2) + 1
            //}
            //else if ((search < m)&&(numbers.Count==2))       //((count % 2 == 1) && (count != 1))
            //{
            //    Console.WriteLine("The element you are looking for is with index {0} in your array.", m - count);   //[m - (count/2) +1]
            //}
                //else if ((count % 2 == 0) && (search != m))
                //{
                //    Console.WriteLine("The element you are looking for is with index {0} in your array.", count * 2 + 1);
                //}
            //}
            if ((search == numbers[numbers.Count / 2]) && ((numbers.Count == 1)||(numbers.Count == 2)) && (search > middle) && (middle2 >= 2))
            {
                if (firstCount % 2 == 1)
                {
                    Console.WriteLine("The element you are looking for is with index {0} in your array.", m * 2);
                }
                else
                {
                    Console.WriteLine("The element you are looking for is with index {0} in your array.", (m * 2) - 1);
                }
            }
            if ((search == numbers[numbers.Count / 2]) && ((numbers.Count == 1) || (numbers.Count == 2)) && (search < middle) && (middle2 >= 2))
            {
                Console.WriteLine("The element you are looking for is with index {0} in your array.", m - 1);
            }
            if ((search == numbers[numbers.Count / 2]) && (numbers.Count == 1) && (search > middle) && (middle2 == 1))
            {
                Console.WriteLine("The element you are looking for is with index {0} in your array.", count * 2);
            }
            if ((search == numbers[numbers.Count / 2]) && (numbers.Count == 1) && (search < middle) && (count != 1) && (middle2 < 2))
            {
                Console.WriteLine("The element you are looking for is with index {0} in your array.", 0);
            }
            if ((search == numbers[numbers.Count / 2]) && (numbers.Count == 1) && (search < middle) && (count == 1) && (middle2 < 2))
            {
                Console.WriteLine("The element you are looking for is with index {0} in your array.", numbers.Count/2);
            }
   }
}
