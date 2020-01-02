using System;

namespace Problem_01_Calculations
{
    class Calculations
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a & b = {a & b}");
            Console.WriteLine($"a > b = {a > b}");
            Console.WriteLine($"a != b {a != b}");
        }
    }
}
