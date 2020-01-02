using System;

namespace Problem_03_Person
{
    class Program
    {
        static void Main()
        {
            Person p1 = new Person("Pesho", "Peshev", "+359 897 654 321");
            Person p2 = new Person();

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            p2.FirstName = "Gosho";
            p2.LastName = " Goshev";
            p2.PhoneNumber = "+359 123 456 789";

            Console.WriteLine(p2);
        }
    }
}
