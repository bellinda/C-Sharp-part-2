//Write methods that calculate the surface of a triangle by given:
//   - Side and an altitude to it;
//   - Three sides;
//   - Two sides and an angle between them. Use System.Math.

using System;
using System.Collections.Generic;
    class SurfaceOfTriangle
    {
        static void Main()
        {
            Console.WriteLine("Which method do you want to use?");
            Console.WriteLine("Write 1 for side and altitude to it");
            Console.WriteLine("Write 2 for three sides");
            Console.WriteLine("Write 3 for two sides and an angle between them");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.Write("Enter the length of the side ");
                        double side = double.Parse(Console.ReadLine());
                        Console.Write("Enter the length of the altitude to the following side ");
                        double altitude = double.Parse(Console.ReadLine());
                        SideAndAltitudeToIt(side, altitude);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter the length of the three sides:");
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        double c = double.Parse(Console.ReadLine());
                        ThreeSides(a, b, c);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter the lengths of the sides:");
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Enter the value of the angle between the sides: ");
                        int gama = int.Parse(Console.ReadLine());
                        TwoSidesAndAngleBetweenThem(a, b, gama);
                        break;
                    }
            }
        }

        private static void TwoSidesAndAngleBetweenThem(double a, double b, int gama)
        {
            double gamaInRadians = gama * Math.PI / 180;
            double sinusOfAngle = Math.Sin(gamaInRadians);  //Math.Sin() calculates the angle in radians
            double surface = a * b * sinusOfAngle / 2;
            Console.WriteLine(surface);
        }

        private static void ThreeSides(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double surface = Math.Sqrt((p*(p-a)*(p-b)*(p-c)));
            Console.WriteLine(surface);
        }

        private static void SideAndAltitudeToIt(double side, double altitude)
        {
            double surface = side * altitude / 2;
            Console.WriteLine(surface);
        }
    }
