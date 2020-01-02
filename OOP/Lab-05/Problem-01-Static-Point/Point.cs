using System;

namespace Problem_01_Static_Point
{
    public class Point
    {
        // Field
        private double x;

        // Field
        private double y;

        public void InputX()
        {
            Console.Write("x = ");
            x = double.Parse(Console.ReadLine());
        }

        public void InputY()
        {
            Console.Write("y = ");
            y = double.Parse(Console.ReadLine());
        }

        public double X => x;

        public double Y => y;

        public static double Distance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));
        }
    }
}
