using System;

namespace Problem_02_Instance_Complex_Number
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

        public ComplexNumber SumComplexNumbers(ComplexNumber y)
        {
            ComplexNumber c = new ComplexNumber();

            c.a = this.a + y.a;
            c.b = this.b + y.b;

            return c;
        }

        public override string ToString()
        {
            return $"{a} + {b} * i";
        }
    }
}
