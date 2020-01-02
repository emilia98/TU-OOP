using System;

namespace Problem_01_Instance_Point
{
    class InstancePoint
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

            double distance = p1.Distance(p2);

            Console.WriteLine($"Distance = {distance}");
        }
    }
}
