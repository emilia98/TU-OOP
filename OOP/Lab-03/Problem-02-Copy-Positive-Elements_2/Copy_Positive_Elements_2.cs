using System;
using System.Linq;

namespace Problem_02_Copy_Positive_Elements_2
{
    class Copy_Positive_Elements_2
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("x = ");
                int x = int.Parse(Console.ReadLine());
                array[i] = x;
            }

            int[] array_copy = array.Where(x => x > 0).ToArray();
            int index = -1;

            // Full Array
            foreach(int x in array)
            {
                Console.WriteLine($"array[{++index}] = {x}");
            }

            Console.WriteLine();

            index = -1;

            // Positive Elements Only
            foreach(int x in array_copy)
            {
                Console.WriteLine($"array[{++index}] = {x}");
            }
        }
    }
}