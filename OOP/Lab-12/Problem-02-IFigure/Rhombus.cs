using System;

namespace Problem_02_IFigure
{
    public class Rhombus : IFigure
    {
        private double a;
        private double alpha;

        private double toRadians = 0.01745;

        public double Area()
        {
            return this.a * this.a * Math.Sin(this.alpha * toRadians);
        }

        public void Input()
        {
            Console.Write("a = ");
            this.a = Double.Parse(Console.ReadLine());
            Console.Write("alpha = ");
            this.alpha = Double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"a = {this.a:f3}; alpha = {this.alpha:f3}");
        }
    }
}
