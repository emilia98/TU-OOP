using System;

namespace Problem_03_IPreditor
{
    public class Cat : Preditor
    {
        private string type = "Cat";
        public override void Eat()
        {
            Console.WriteLine($"{type} is eating!");
        }

        public override void GetSound()
        {
            Console.WriteLine("Meow-meow...");
        }

        public override void Rest()
        {
            Console.WriteLine($"{type} is sleeping on the couch...");
        }

        public override void Run()
        {
            Console.WriteLine($"{type} is running...");
        }

        public override void Walk()
        {
            Console.WriteLine($"{type} is going for a walk...");
        }
    }
}
