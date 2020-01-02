using System;

namespace Problem_03_Square_Roots
{
    class SquareRoots
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double D = b * b - 4 * a * c;

            if(D < 0)
            {
                Console.WriteLine("NO ROOTS");
                return;
            }

            double x1 = (-b - Math.Sqrt(D)) / (2 * a);
            double x2 = (-b + Math.Sqrt(D)) / (2 * a);

            Console.WriteLine($"x1 = {x1}; x2 = {x2}");
        }
    }
}
