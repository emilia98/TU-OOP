using System;

namespace Problem_02_Dot
{
    public class Dot2D
    {
        // field
        protected double x;

        // field
        protected double y;

        public double X
        {
            get { return this.x; }
        }

        public double Y
        {
            get { return this.y; }
        }

        public Dot2D()
        {
            Console.Write("x = ");
            this.x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            this.y = double.Parse(Console.ReadLine());
        }

        public Dot2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }


        public virtual void ShowCoordinates()
        {
            Console.WriteLine($"(x, y) = ({this.X}, {this.Y})");
        }
    }
}
