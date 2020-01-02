using System;

namespace Problem_01_Figure
{
    public class Circle : Figure
    {
        private double radius;
        public override double Area()
        {
            return this.radius * this.radius * Math.PI;
        }

        public override void Input()
        {
            Console.Write("radius = ");
            this.radius = Double.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            Console.WriteLine($"radius = {this.radius:f2}");
        }
    }
}
