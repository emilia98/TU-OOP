using System;
using System.Linq;

namespace Problem_01_Straight_Reversed_Order_2
{
    class Straight_Reversed_Order_2
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("x = ");
                double x = double.Parse(Console.ReadLine());
                array[i] = x;
            }

            // Straight Order
            int index = 0;
            foreach(double x in array)
            {
                Console.WriteLine($"array[{index}] = {x}");
                index++;
            }

            index = n - 1;
            Console.WriteLine();

            // Reversed Order
            double[] array_reversed = array.Reverse().ToArray();

            foreach(double x in array_reversed)
            {
                Console.WriteLine($"array[{index}] = {x}");
                index--;
            }

            index = 0;
            Console.WriteLine();

            // With Even Indexes
            foreach(double x in array)
            {
                if(index % 2 == 0)
                {
                    Console.WriteLine($"array[{index}] = {x}");
                }

                index++;
            }

            index = 0;
            Console.WriteLine();

            // With Odd Indexes
            foreach(double x in array)
            {
                if(index % 2 == 1)
                {
                    Console.WriteLine($"array[{index}] = {x}");
                }

                index++;
            }
        }
    }
}
