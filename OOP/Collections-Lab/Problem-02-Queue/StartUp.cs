using System;
using System.Collections.Generic;

namespace Problem_02_Queue
{
    class StartUp
    {
        static void Main()
        {
            Queue<double> queue = new Queue<double>();

            Console.Write("x = ");
            queue.Enqueue(double.Parse(Console.ReadLine()));

            Random rnd = new Random();

            for (int i = 0; i < 8; i++)
            {
                queue.Enqueue(rnd.NextDouble() * 100);
            }

            foreach (var item in queue)
            {
                Console.WriteLine($"{item:f2}");
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Removing element = {queue.Dequeue():f2}");
            }

            Console.WriteLine($"First element is {queue.Peek():f2}");

            foreach (var item in queue)
            {
                Console.WriteLine($"{item:f2}");
            }

        }
    }
}
