using System;

namespace Problem_01_Pet
{
    class Problem1
    {
        static void Main()
        {
            Pet pet = new Pet();
            Console.WriteLine(pet.GetSound());
            pet.Info();

            Dog dog1 = new Dog(null, 0);
            dog1.Name = "Sharoto";
            dog1.Age = 3;

            Pet dog2 = new Dog("Sharo", 2);

            Pet dog3 = new Dog();

            Console.WriteLine(dog1.GetSound());
            dog1.Info();
            Console.WriteLine();
            Console.WriteLine(dog2.GetSound());
            dog2.Info();
            Console.WriteLine();
            Console.WriteLine(dog3.GetSound());
            dog3.Info();
            Console.WriteLine();

            Cat cat1 = new Cat("Kitty Cat", 2);

            Pet cat2 = new Cat(null, 0);
            cat2.Name = "Catty Kit";
            cat2.Age = 1;

            Pet cat3 = new Cat();

            Console.WriteLine(cat1.GetSound());
            cat1.Info();
            Console.WriteLine();

            Console.WriteLine(cat2.GetSound());
            cat2.Info();
            Console.WriteLine();

            Console.WriteLine(cat3.GetSound());
            cat3.Info();
            Console.WriteLine();
        }
    }
}
