using System;
using System.Collections.Generic;
    class SolveThreeTasks
    {
        static void Main()
        {
            Console.WriteLine("Choose what you want to do:");
            Console.WriteLine("1 = reverse the digits of a number");
            Console.WriteLine("2 = calculate the average of a sequence of integers");
            Console.WriteLine("3 = solve a linear equation a*x + b = 0");
            int choice = int.Parse(Console.ReadLine());


            if (choice == 1)
            {
                Console.Write("Enter your number: ");
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("Your number should be positive. Try again!");
                }
                else
                {
                    ReverseDigits(num);
                }
            }

            if (choice == 2)
            {
                List<int> sequence = new List<int>();
                Console.Write("How many integers will you have in the sequance? ");
                int n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Your sequance is empty. Try with a new one!");
                }
                else
                {
                    Console.WriteLine("Enter the integers: ");
                    for (int i = 0; i < n; i++)
                    {
                        int temp = int.Parse(Console.ReadLine());
                        sequence.Add(temp);
                    }
                    Console.WriteLine("Average of the sequance = {0}", FindAverage(sequence));
                }
            }

            if (choice == 3)
            {
                Console.Write("Enter the value of a   ");
                float a = float.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("a couldn't be equal to 0");
                }
                else
                {
                    Console.Write("Enter the value of b   ");
                    float b = float.Parse(Console.ReadLine());
                    Console.WriteLine("x = {0}", SolveLinearEquation(a, b));
                }
            }


        }

        static void ReverseDigits(int number)
        {
            List<int> digits = new List<int>();
            while (number > 0)
            {
                digits.Add(number % 10);
                number/=10;
            }
            for (int i = 0; i < digits.Count; i++)
            {
                Console.Write(digits[i]);
            }
            Console.WriteLine();
        }

        static float FindAverage(List<int> numbers)  //средно аритметично
        {
            float sum = (float)numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                sum += (float)numbers[i];
            }
            return (sum / numbers.Count);
        }

        static float SolveLinearEquation(float a, float b)
        {
            float x;
            if (b == 0)
            {
                x = 0;
            }
            else
            {
                x = (-b) / a;
            }
            return x;
        }
    }
