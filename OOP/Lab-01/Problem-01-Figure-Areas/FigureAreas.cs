using System;

namespace Problem_01_Figure_Areas
{
    class FigureAreas
    {
        static void Main()
        {
            Console.WriteLine("square - 1");
            Console.WriteLine("rectangle - 2");
            Console.WriteLine("circle - 3");
            Console.WriteLine("triangle - 4");

            // int choice = int.Parse(Console.ReadLine());
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    FindSquareArea();
                    break;
                case "2":
                    FindRectangleArea();
                    break;
                case "3":
                    FindCircleArea();
                    break;
                case "4":
                    FindTriangleArea();
                    break;
                default:
                    Console.WriteLine("Invalid Figure!");
                    return;
            }
        }

        static void FindSquareArea()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            double area = a * a;

            Console.WriteLine("Area = {0}", area);
        }

        static void FindRectangleArea()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            double area = a * b;

            Console.WriteLine("Area = {0}", area);
        }

        static void FindCircleArea()
        {
            Console.Write("r = ");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;

            Console.WriteLine("Area = {0}", area);
        }

        static void FindTriangleArea()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            if (a + b <= c || b + c <= a || a + c <= b)
            {
                Console.WriteLine("Invalid Triangle");
                return;
            }

            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("Area = {0}", area);
        }
    }
}
