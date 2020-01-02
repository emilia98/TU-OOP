using System;

namespace Problem_02_IFigure
{
    public class Rectangle : IFigure
    {
        private double a;
        private double b;

        public double Area()
        {
            return this.a * this.b;
        }

        public void Input()
        {
            Console.Write("a = ");
            this.a = Double.Parse(Console.ReadLine());
            Console.Write("b = ");
            this.b = Double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"a = {this.a:f2}; b = {this.b:f2}");
        }
    }
}
