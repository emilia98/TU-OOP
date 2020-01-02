using System;

namespace Problem_01_Pet
{
    public class Pet
    {
        // field
        private string name;

        // field
        private int age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Pet()
        {
            Console.Write("Name = ");
            this.name = Console.ReadLine();
            Console.Write("Age = ");
            this.age = Int32.Parse(Console.ReadLine());
        }

        public Pet(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual string GetSound()
        {
            return "Some pet sound here";
        }

        public virtual void Info()
        {
            Console.WriteLine($"Pet: ");
            Console.WriteLine(this.GetPetData());
        }

        protected string GetPetData()
        {
            return $"Name: {this.name}; Age: {this.age}";
        }
    }
}
