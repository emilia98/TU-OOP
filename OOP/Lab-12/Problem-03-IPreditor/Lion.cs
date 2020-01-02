using System;

namespace Problem_03_IPreditor
{
    public class Lion : Preditor
    {
        private string type = "Lion";
        public override void Eat()
        {
            Console.WriteLine($"{type} is eating!");
        }

        public override void GetSound()
        {
            Console.WriteLine("Rrrrrr...");
        }

        public override void Rest()
        {
            Console.WriteLine($"{type} is sleeping under a tree...");
        }

        public override void Run()
        {
            Console.WriteLine($"{type} is running fast...");
        }

        public override void Walk()
        {
            Console.WriteLine($"{type} is going for a walk...");
        }
    }
}
