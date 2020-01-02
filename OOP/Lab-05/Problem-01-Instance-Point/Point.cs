using System;

namespace Problem_01_Instance_Point
{
    public class Point
    {
        private double x;

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

        public double Distance(Point b)
        {
            return Math.Sqrt((this.x - b.x) * (this.x - b.x) + (this.y - b.y) * (this.y - b.y));
        }
    }
}
