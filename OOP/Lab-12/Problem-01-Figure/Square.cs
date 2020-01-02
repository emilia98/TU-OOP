using System;

namespace Problem_01_Figure
{
    public class Square : Figure
    {
        private double a;

        public override double Area()
        {
            return this.a * this.a;
        }

        public override void Input()
        {
            Console.Write("a = ");
            this.a = Double.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            Console.WriteLine($"a = {this.a}");
        }
    }
}
