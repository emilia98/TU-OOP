using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01_Figures
{
    public class Triangle
    {
        // Field
        private double a;

        // Field
        private double b;

        // Field
        private double c;

        public double GetA => a;

        public double GetB => b;

        public double GetC => c;


        public void EnterSides()
        {
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());
        }

        public bool IsValid()
        {
            return a + b > c && a + c > b && b + c > a;
        }

        public double A => a;

        public double B => b;

        public double C => c;

        public void FindArea()
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Area of triangle = {area:f2}");
        }
    }
}
