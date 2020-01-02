using System;

namespace Problem_01_Array_Copy
{
    class ArrayCopy
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int[] arrA = new int[n];
            int[][] arrB = new int[n / 2][];

            arrB[0] = new int[n / 2];
            arrB[1] = new int[n / 2];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"arrA[{i}] = ");
                arrA[i] = int.Parse(Console.ReadLine());
            }

            Array.Copy(arrA, 0, arrB[0], 0, n / 2);
            Array.Copy(arrA, n / 2, arrB[1], 0, n / 2);

            Console.WriteLine(String.Join(", ", arrA));
            Console.WriteLine();
            Console.WriteLine(String.Join(", ", arrB[0]));
            Console.WriteLine(String.Join(", ", arrB[1]));
        }
    }
}
