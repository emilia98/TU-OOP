using System;

namespace Problem_01_Figure
{
    public class Rectangle : Figure
    {
        private double a;
        private double b;

        public override double Area()
        {
            return this.a * this.b;
        }

        public override void Input()
        {
            Console.Write("a = ");
            this.a = Double.Parse(Console.ReadLine());
            Console.Write("b = ");
            this.b = Double.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            Console.WriteLine($"a = {this.a:f2}; b = {this.b:f2}");
        }
    }
}
