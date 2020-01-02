using System;

namespace Problem_01_Figures
{
    public class Rectangle
    {
        // Field
        private double a;

        // Field
        private double b;

        public void EnterSides()
        {
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
        }

        public double GetA => a;

        public double GetB => b;

        public void FindArea()
        {
            double area = a * b;
            Console.WriteLine("Area of rectangle = {0:f2}", area);
        }
    }
}
