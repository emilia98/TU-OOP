using System;

namespace Problem_01_Figures
{
    public class Cone : Circle
    {
        // field
        private double height;

        public double Height
        {
            get { return this.height; }
        }

        public Cone() : base()
        {
            Console.Write("Height = ");
            this.height = double.Parse(Console.ReadLine());
        }

        public Cone(double height, double radius) : base(radius)
        {
            this.height = height;
        }

        public double Volume()
        {
            return this.Area() * this.height / 3;
        }
    }
}
