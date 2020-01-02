using System;

namespace Problem_03_IPreditor
{
    class StartUp
    {
        static void Main()
        {
            Preditor lion = new Lion();
            IPreditor tiger = new Tiger();
            Cat cat = new Cat();

            lion.Eat();
            lion.GetSound();
            lion.Rest();
            lion.Run();
            lion.Walk();

            Console.WriteLine();

            tiger.Eat();
            tiger.GetSound();
            tiger.Rest();
            tiger.Run();
            tiger.Walk();

            Console.WriteLine();

            cat.Eat();
            cat.GetSound();
            cat.Rest();
            cat.Run();
            cat.Walk();
        }
    }
}
