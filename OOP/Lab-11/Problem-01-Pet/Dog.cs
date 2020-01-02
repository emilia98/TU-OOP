using System;

namespace Problem_01_Pet
{
    public class Dog : Pet
    {
        public Dog() : base()
        {
        }

        public Dog(string name, int age) : base(name, age)
        {
        }

        public override string GetSound()
        {
            return "Aw-Aw";
        }

        public override void Info()
        {
            Console.WriteLine("Dog: ");
            Console.WriteLine(this.GetPetData());
        }
    }
}
