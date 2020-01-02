using System;

namespace Problem_02_Static_Complex_Number
{
    class StaticComplexNumber
    {
        static void Main()
        {
            ComplexNumber cn1 = new ComplexNumber();
            ComplexNumber cn2 = new ComplexNumber();

            Console.WriteLine("First Complex Number");
            cn1.InputNumber();
            Console.WriteLine($"cn1 = {cn1}");

            Console.WriteLine("Second Complex Number");
            cn2.InputNumber();
            Console.WriteLine($"cn2 = {cn2}");

            Console.WriteLine();
            Console.WriteLine($"Sum = {ComplexNumber.SumComplexNumbers(cn1, cn2)}");
        }
    }
}
