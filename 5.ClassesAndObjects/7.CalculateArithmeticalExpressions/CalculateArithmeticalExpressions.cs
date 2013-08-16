﻿//*Write a program that calculates the value of given arithmetical expression. The expression can contain the following elements only:
//      - real numbers, e.g. 5, 18.33, 3.14159, 12.6
//      - arithmetic operators: +, -, *, / (standart priorities)
//      - Mathematical functions: ln(x), sqrt(x), pow(x, y)
//      - Brackets (for changing the default priorities)
//Examples: 
// (3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7) -> ~10.6
// pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5 * 0.3) -> ~21.22

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Globalization;
    class CalculateArithmeticalExpressions
    {
        public static List<string> brackets = new List<string>() { "(" , ")" };

        public static List<char> arithmeticOperators = new List<char>() { '+', '-', '*', '/' };

        public static List<string> functions = new List<string>() { "ln", "pow", "sqrt" };

        public static string DeleteSpaces(string input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    result.Append(input[i]);
                }
            }
            return result.ToString();
        }

        public static List<string> SeparateTolkens(string input)
        {
            List<string> result = new List<string>();
            var number = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i]=='-'&& (i==0 || input[i-1]==',' || input[i]=='('))
                {
                    number.Append('-');
                }
                else if(char.IsDigit(input[i]) || input[i] == '.')
                {
                    number.Append(input[i]);
                }
                else if (!char.IsDigit(input[i]) && (input[i] != '.') && number.Length != 0)
                {
                    result.Add(number.ToString());
                    number.Clear();
                    i--;
                }
                else if (input[i] == '(')
                {
                    result.Add("(");
                }
                else if (input[i] == ')')
                {
                    result.Add(")");
                }
                else if (arithmeticOperators.Contains(input[i]))
                {
                    result.Add(input[i].ToString());
                }
                else if (input[i] == ',')
                {
                    result.Add(",");
                }
                else if (i + 1 < input.Length && input.Substring(i, 2).ToLower() == "ln")
                {
                    result.Add("ln");
                    i++;
                }
                else if (i + 2 < input.Length && input.Substring(i, 3).ToLower() == "pow")
                {
                    result.Add("pow");
                    i += 2;
                }
                else if (i + 3 < input.Length && input.Substring(i, 4).ToLower() == "sqrt")
                {
                    result.Add("sqrt");
                    i += 3;
                }
                else
                {
                    throw new ArgumentException("Invalid expression");
                }
                
            }

            if (number.Length != 0)
            {
                result.Add(number.ToString());
            }
            return result;
        }

        public static void PutInvariantCulture()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }

        public static int Precedence(string arithmeticOperator)
        {
            if (arithmeticOperator == "+" || arithmeticOperator == "-")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public static Queue<string> ConvertToReversePolishNotation(List<string> tokens)
        {
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < tokens.Count; i++)
            {
                var currentToken = tokens[i];
                double number;

                if (double.TryParse(currentToken, out number))
                {
                    queue.Enqueue(number.ToString());
                }
                else if (functions.Contains(currentToken))
                {
                    stack.Push(currentToken);
                }
                else if (currentToken == ",")
                {
                    if (!stack.Contains("(") || stack.Count == 0)
                    {
                        throw new ArgumentException("Invalid brackets or function separator");
                    }
                    while (stack.Peek() != "(")
                    {
                        queue.Enqueue(stack.Pop());
                    }
                }
                else if (arithmeticOperators.Contains(currentToken[0]))
                {
                    while(stack.Count != 0 && arithmeticOperators.Contains(stack.Peek()[0]) && Precedence(currentToken) <= Precedence(stack.Peek()))
                    {
                        queue.Enqueue(stack.Pop());
                    }

                    stack.Push(currentToken);
                }
                else if (currentToken == "(")
                {
                    stack.Push("(");
                }
                else if (currentToken == ")")
                {
                    if (!stack.Contains("(") || stack.Count == 0)
                    {
                        throw new ArgumentException("Invalid brackets");
                    }
                    while (stack.Peek() != "(")
                    {
                        queue.Enqueue(stack.Pop());
                    }
                    stack.Pop();
                    if (stack.Count != 0 && functions.Contains(stack.Peek()))
                    {
                        queue.Enqueue(stack.Pop());
                    }
                }
            }
            while (stack.Count != 0)
            {
                if (brackets.Contains(stack.Peek()))
                {
                    throw new ArgumentException("Invalid brackets position");
                }
                queue.Enqueue(stack.Pop());
            }

            return queue;
        }

        public static double GetResultFromRPN(Queue<string> queue)
        {
            Stack<double> stack = new Stack<double>();
            while (queue.Count != 0)
            {
                double number;
                string currentTolken = queue.Dequeue();
                if (double.TryParse(currentTolken, out number))
                {
                    stack.Push(number);
                }
                else if(arithmeticOperators.Contains(currentTolken[0]) || functions.Contains(currentTolken))
                {
                    if (currentTolken == "+")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(firstValue + secondValue);
                    }
                    else if (currentTolken == "-")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(secondValue - firstValue);
                    }
                    else if (currentTolken == "*")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(secondValue * firstValue);
                    }
                    else if (currentTolken == "/")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(secondValue / firstValue);
                    }
                    else if (currentTolken == "pow")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(Math.Pow(secondValue, firstValue));
                    }
                    else if (currentTolken == "sqrt")
                    {
                        if (stack.Count < 1)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double value = stack.Pop();

                        stack.Push(Math.Sqrt(value));
                    }
                    else if (currentTolken == "ln")
                    {
                        if (stack.Count < 1)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double value = stack.Pop();

                        stack.Push(Math.Log(value));
                    }
                }
            }

            if (stack.Count == 1)
            {
                return stack.Pop();
            }
            else
            {
                throw new ArgumentException("Invalid expression");
            }
        }

        static void Main()
        {
            PutInvariantCulture();

            string input = Console.ReadLine().Trim();
            string inputWithoutSpaces = DeleteSpaces(input);
            List<string> separatedTolkens = SeparateTolkens(inputWithoutSpaces);
            var reversePolishNotation = ConvertToReversePolishNotation(separatedTolkens);

            var finalResult = GetResultFromRPN(reversePolishNotation);
            Console.WriteLine(finalResult);
        }
    }

