using System;

namespace Problem_01_Figures
{
    public class Circle
    {
        private double radius;

        public void EnterRadius()
        {
            Console.Write("r = ");
            radius = double.Parse(Console.ReadLine());
        }

        public double GetRadius => radius;

        public void FindArea()
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Area of circle = {area}");
        }
    }
}
