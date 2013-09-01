//Write a program to check if in a given expression the brackets are put correctly. 
//Example of correct expression: ((a+b)/5-d)
//Example of incorrect expression: )(a+b))

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    class CorrectBrackets
    {
        static void Main()
        {
            Console.Write("Enter your expression: ");
            string expression = Console.ReadLine();
            bool correct;
            int openBrackets = 0;
            int closeBrackets = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    openBrackets++;
                }
                if (expression[i] == ')')
                {
                    closeBrackets++;
                }
            }
            if (openBrackets == closeBrackets)
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
            Console.WriteLine("The expression is correct: {0}", correct);
        }
    }
