using System;

namespace Problem_01_Figures
{
    public class Cylinder : Circle
    {
        // field
        private double height;

        public double Height
        {
            get { return this.height; }
        }

        public Cylinder() : base()
        {
            Console.Write("Height = ");
            this.height = double.Parse(Console.ReadLine());
        }

        public Cylinder(double height, double radius) : base(radius)
        {
            this.height = height;
        }

        public double Volume()
        {
            return this.Area() * this.height;
        }
    }
}
