using System;

namespace Problem_02_IFigure
{
    public class Square : IFigure
    {
        private double a;

        public double Area()
        {
            return this.a * this.a;
        }

        public void Input()
        {
            Console.Write("a = ");
            this.a = Double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine($"a = {this.a}");
        }
    }
}
