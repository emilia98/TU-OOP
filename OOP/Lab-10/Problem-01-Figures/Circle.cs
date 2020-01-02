using System;

namespace Problem_01_Figures
{
    public class Circle
    {
        // field
        private double radius;

        public double Radius
        {
            get { return this.radius; }
        }

        public Circle()
        {
            Console.Write("radius = ");
            double radius = double.Parse(Console.ReadLine());
            this.radius = radius;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return this.radius * this.radius * Math.PI;
        }
    }
}
