using System;

namespace Problem_01_Pet
{
    public class Cat : Pet
    {
        public Cat() : base()
        {
        }

        public Cat(string name, int age) : base(name, age)
        {
        }

        public override string GetSound()
        {
            return "Meow-Meow";
        }

        public override void Info()
        {
            Console.WriteLine("Cat: ");
            Console.WriteLine(this.GetPetData());
        }
    }
}
