using System;

namespace Problem_02_Copy_Positive_Elements
{
    class Copy_Positive_Elements
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            int positiveElementsCounter = 0;

            for(int i = 0; i < n; i++)
            {
                Console.Write("x = ");
                int x = int.Parse(Console.ReadLine());
                array[i] = x;

                if(x > 0)
                {
                    positiveElementsCounter++;
                }
            }

            int[] array_copy = new int[positiveElementsCounter];
            int index = 0;

            for(int i = 0; i < n; i++)
            {
                if(array[i] > 0)
                {
                    array_copy[index] = array[i];
                    index++;
                }
            }

            // Full Array
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }

            // Positive Elements Only
            for(int i = 0; i < array_copy.Length; i++)
            {
                Console.WriteLine($"array_copy[{i}] = {array_copy[i]}");
            }
        }
    }
}