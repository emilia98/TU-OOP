using System;

namespace Problem_02_Static_Complex_Number
{
    public class ComplexNumber
    {
        private double a;

        private double b;

        public void InputNumber()
        {
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
        }

        // public string Z => $"{a} + {b} * i";

        public static ComplexNumber SumComplexNumbers(ComplexNumber x, ComplexNumber y)
        {
            ComplexNumber c = new ComplexNumber();

            c.a = x.a + y.a;
            c.b = x.b + y.b;

            return c;
        }

        public override string ToString()
        {
            return $"{a} + {b} * i";
        }
    }
}
