using System;

namespace Problem_01_Figure
{
    public class Rhombus : Figure
    {
        private double a;
        private double alpha;

        private double toRadians = 0.01745;

        public override double Area()
        {
            return this.a * this.a * Math.Sin(this.alpha * toRadians);
        }

        public override void Input()
        {
            Console.Write("a = ");
            this.a = Double.Parse(Console.ReadLine());
            Console.Write("alpha = ");
            this.alpha = Double.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            Console.WriteLine($"a = {this.a:f3}; alpha = {this.alpha:f3}");
        }
    }
}
