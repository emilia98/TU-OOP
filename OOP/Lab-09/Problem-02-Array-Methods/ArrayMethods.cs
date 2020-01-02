using System;
using System.Linq;

namespace Problem_02_Array_Methods
{
    class ArrayMethods
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int[] arrA = new int[n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                // Console.Write($"arrA[{i}] = ");
                arrA[i] = rnd.Next(-1000, 1000);
            }

            // Find the sum of all elements
            Console.WriteLine($"Sum = {arrA.Sum()}");
            // Find the average of all elements
            Console.WriteLine($"Average = {arrA.Average()}");
            // Find the max element in the array
            Console.WriteLine($"Max = {arrA.Max()}");
            // Find the min element in the array
            Console.WriteLine($"Min = {arrA.Min()}");

            int[] arrB = (int[])arrA.Clone();

            // Sort the second array
            Array.Sort(arrB);

            Console.WriteLine(string.Join(", ", arrA));
            Console.WriteLine(string.Join(", ", arrB));
        }
    }
}
