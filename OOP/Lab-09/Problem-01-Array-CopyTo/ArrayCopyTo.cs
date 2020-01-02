using System;

namespace Problem_01_Array_CopyTo
{
    class ArrayCopyTo
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int[] arrA = new int[n];
            int[][] arrB = new int[n / 2][];

            arrB[0] = new int[n / 2];
            arrB[1] = new int[n / 2];

            for(int i = 0; i < n; i++)
            {
                Console.Write($"arrA[{i}] = ");
                arrA[i] = int.Parse(Console.ReadLine());
            }

            int[] firstHalf = new int[n / 2];
            int[] secondHalf = new int[n / 2];

            Array.Copy(arrA, 0, firstHalf, 0, n / 2);
            Array.Copy(arrA, n / 2, secondHalf, 0, n / 2);

            firstHalf.CopyTo(arrB[0], 0);
            secondHalf.CopyTo(arrB[1], 0);

            Console.WriteLine(String.Join(", ", arrA));
            Console.WriteLine();
            Console.WriteLine(String.Join(", ", firstHalf));
            Console.WriteLine(String.Join(", ", secondHalf));
        }
    }
}
