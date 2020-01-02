using System;

namespace Problem_02_IFigure
{
    public class Circle : IFigure
    {
        private double radius;
        public double Area()
        {
            return this.radius * this.radius * Math.PI;
        }

        public void Input()
        {
            Console.Write("radius = ");
            this.radius = Double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"radius = {this.radius:f2}");
        }
    }
}
