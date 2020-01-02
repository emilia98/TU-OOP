using System;

namespace Problem_01_Straight_Reversed_Order
{
    class Straight_Reversed_Order
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("x = ");
                double x = double.Parse(Console.ReadLine());

                array[i] = x;
            }

            // Straight Order
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }

            Console.WriteLine();

            // Reversed Order
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }

            Console.WriteLine();

            // Elements with even index
            for(int i = 0; i < n; i += 2)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }

            Console.WriteLine();

            // Elements with odd index
            for(int i = 1; i < n; i += 2)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }
        }
    }
}
