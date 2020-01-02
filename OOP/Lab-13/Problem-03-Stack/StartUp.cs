using System;

namespace Problem_03_Stack
{
    class StartUp
    {
        static void Main()
        {
            Stack<string> stack_1 = new Stack<string>(3);
            Console.WriteLine($"Is Empty = {stack_1.IsEmpty()}");
            stack_1.Push("Pesho");
            stack_1.Push("Hello");
            stack_1.Push("World");
            Console.WriteLine($"Is Full = {stack_1.IsFull()}");
            Console.WriteLine(stack_1.Peek());

            Stack<double> stack_2 = new Stack<double>(4);
            stack_2.Push(3.186532);
            Console.WriteLine($"Is Empty = {stack_2.IsEmpty()}");
            stack_2.Push(78);
            stack_2.Push(-2.3);
            Console.WriteLine($"Is Full = {stack_2.IsFull()}");
            stack_2.Push(2.3);
            stack_2.Push(-0.2978);
            Console.WriteLine(stack_2.Peek());
        }
    }
}
