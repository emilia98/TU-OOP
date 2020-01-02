using System;

namespace Problem_01_Static_Point
{
    class StaticPoint
    {
        static void Main()
        {
            Point p1 = new Point();
            Point p2 = new Point();

            Console.WriteLine("First Point");
            p1.InputX();
            p1.InputY();

            Console.WriteLine($"x1 = {p1.X}");
            Console.WriteLine($"y1 = {p1.Y}");

            Console.WriteLine("Second Point");
            p2.InputX();
            p2.InputY();

            Console.WriteLine($"x1 = {p2.X}");
            Console.WriteLine($"y1 = {p2.Y}");

            double distance = Point.Distance(p1, p2);

            Console.WriteLine($"Distance = {distance}");
        }
    }
}
