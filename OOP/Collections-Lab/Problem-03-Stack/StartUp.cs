using System;
using System.Collections.Generic;

namespace Problem_03_Stack
{
    class StartUp
    {
        static void Main()
        {
            Stack<string> stack = new Stack<string>();

            Console.Write("x = ");
            stack.Push(Console.ReadLine());
            stack.Push("World");

            Random rnd = new Random();

            for (int i = 0; i < 8; i++)
            {
                string generated = String.Empty;

                int rndNumber = rnd.Next(65, 90);
                generated += (char)rndNumber;

                for (int j = 0; j < 4; j++)
                {
                    rndNumber = rnd.Next(97, 122);
                    generated += (char)rndNumber;
                }

                stack.Push(generated);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Removed element = {stack.Pop()}");
            }

            Console.WriteLine($"Last element is: {stack.Peek()}");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
