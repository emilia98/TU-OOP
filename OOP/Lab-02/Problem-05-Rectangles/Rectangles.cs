using System;

namespace Problem_05_Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.Write("a1 = ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("b1 = ");
            double b1 = double.Parse(Console.ReadLine());

            Console.Write("a2 = ");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("b2 = ");
            double b2 = double.Parse(Console.ReadLine());

            double s1 = FindArea(a1, b1);
            double s2 = FindArea(a2, b2);

            Console.WriteLine($"Area of rectangle 1 = {s1}");
            Console.WriteLine($"Area of rectangle 2 = {s2}");

            Console.WriteLine(s1 > s2 ? "First" : "Second");
        }

        static double FindArea(double a, double b)
        {
            return a * b;
        }
    }
}
