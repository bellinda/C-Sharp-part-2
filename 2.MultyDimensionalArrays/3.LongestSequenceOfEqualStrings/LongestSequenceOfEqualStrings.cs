using System;
using System.Collections.Generic;
    class LongestSequenceOfEqualStrings
    {
        static void Main()
        {
            //string[,] symbols = {
            //                        {"ha", "fifi", "ho", "hi"},
            //                        {"fo", "ha", "hi", "xx"},
            //                        {"xxx", "ho", "ha", "xx"},
            //                    };

            Console.Write("Rows = ");
            int t = int.Parse(Console.ReadLine());
            Console.Write("Columns = ");
            int s = int.Parse(Console.ReadLine());
            string[,]symbols = new string[t, s];
            for (int row = 0; row < t; row++)
            {
                for (int col = 0; col < s; col++)
                {
                    symbols[row, col] = Console.ReadLine();
                }
            }

            int counter = 1;
            int bestLength = 1;
            int startRow = 0;
            int startCol = 0;
            int rowCopy;
            int colCopy;
            string bestPosition ="";

            //proverka za ednakvi elemnti v kolona
            for (int col = 0; col < symbols.GetLength(1); col++)
            {
                int row = 0;
                while (symbols[row, col] != symbols[row + 1, col])
                {
                    row++;
                    if (row >= symbols.GetLength(0) - 2)
                    {
                        break;
                    }
                }
                rowCopy = row;
                while (symbols[row, col] == symbols[row + 1, col])
                {
                    counter++;
                    if (row < symbols.GetLength(0) - 2)
                    {
                        row++;
                    }
                    else
                        break;
                }
                if (bestLength < counter)
                {
                    bestLength = counter;
                    bestPosition = "vertical";
                    startRow = rowCopy;
                    startCol = col;
                }

                counter = 1;
            }

            //proverka za ednakvi elementi na edin red
            for (int row = 0; row < symbols.GetLength(0); row++)
            {
                int col = 0;
                while (symbols[row, col] != symbols[row, col + 1])
                {
                    col++;
                    if (col >= symbols.GetLength(1) - 2)
                    {
                        break;
                    }
                }
                colCopy = col;
                while (symbols[row, col] == symbols[row, col + 1])
                {
                    counter++;
                    if (col < symbols.GetLength(1) - 2)
                    {
                        col++;
                    }
                    else
                        break;
                }
                if (bestLength < counter)
                {
                    bestLength = counter;
                    bestPosition = "horizontal";
                    startRow = row;
                    startCol = colCopy;
                }

                counter = 1;
            }


            //proverka za ednakvi elementi po diagonal nadqsno
            for (int row = 0; row < symbols.GetLength(0) - 1; row++)
            {
                int m = row;
                for (int col = 0; col < symbols.GetLength(1) - 1; col++)
                {
                    int k = col;
                    while (symbols[row, col] != symbols[row + 1, col + 1])
                    {
                        if ((col < symbols.GetLength(1) - 2) && (row < symbols.GetLength(0) - 2))
                        {
                            col++;
                            row++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    colCopy = col;
                    rowCopy = row;
                    while (symbols[row, col] == symbols[row + 1, col + 1])
                    {
                        counter++;
                        if ((col < symbols.GetLength(1) - 2) && (row < symbols.GetLength(0) - 2))
                        {
                            col++;
                            row++;
                        }
                        else
                            break;
                    }
                    if (bestLength < counter)
                    {
                        bestLength = counter;
                        bestPosition = "rigth diagonal";
                        startRow = rowCopy;
                        startCol = colCopy;
                    }

                    counter = 1;
                    row = m;
                    col = k;

                }
            }

            //proverka za ednakvi elementi po diagonala nalqvo

            for (int row = 0; row < symbols.GetLength(0) - 1; row++)
            {
                int m = row;
                for (int col = symbols.GetLength(1) - 1; col > 0; col--)
                {
                    int k = col;
                    while (symbols[row, col] != symbols[row + 1, col - 1])
                    {
                        if ((col > 1) && (row < symbols.GetLength(0) - 2))
                        {
                            col--;
                            row++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    colCopy = col;
                    rowCopy = row;
                    while (symbols[row, col] == symbols[row + 1, col - 1])
                    {
                        counter++;
                        if ((col > 1) && (row < symbols.GetLength(0) - 2))
                        {
                            col--;
                            row++;
                        }
                        else
                            break;
                    }
                    if (bestLength < counter)
                    {
                        bestLength = counter;
                        bestPosition = "left diagonal";
                        startRow = rowCopy;
                        startCol = colCopy;
                    }

                    counter = 1;
                    row = m;
                    col = k;

                }
            }


            //print the sequence of equal elements and its count on the console:

            if (bestPosition == "horizontal")
            {
                Console.WriteLine("The longest sequence of equal elements is a horizontal sequence of {0} elements and they are: ", bestLength);
                for (int i = 0; i < bestLength; i++)
                {
                    Console.Write(symbols[startRow,startCol] + " ");
                }
            }

            if (bestPosition == "vertical")
            {
                Console.WriteLine("The longest sequence of equal elements is a vertical sequence of {0} elements and they are: ", bestLength);
                for (int i = 0; i < bestLength; i++)
                {
                    Console.WriteLine(symbols[startRow, startCol]);
                }
            }

            if (bestPosition == "rigth diagonal")
            {
                int x = 5;
                int y = 5 + t * s;
                Console.WriteLine("The longest sequence of equal elements is like a diagonal on the right side and the sequence is of {0} elements and they are: ", bestLength);
                for (int i = 0; i < bestLength; i++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(symbols[startRow, startCol]);
                    x += 2;
                    y += 2;
                }
            }

            if (bestPosition == "left diagonal")
            {
                int y = 5 + t*s;    
                int x = 17;
                Console.WriteLine("The longest sequence of equal elements is like a diagonal on the left side, it is of {0} elements and they are: ", bestLength);
                for (int i = 0; i < bestLength; i++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(symbols[startRow, startCol]);
                    y += 2;
                    x -= 2;
                }
            }


        }
    }
