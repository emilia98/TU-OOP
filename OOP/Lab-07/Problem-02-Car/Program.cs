using System;

namespace Problem_02_Car
{
    class Program
    {
        static void Main()
        {
            Car car1 = new Car("Golf", "Dark Blue", "EB 1234 BK");
            Car car2 = new Car();

            Console.WriteLine(car1);

            Console.WriteLine(car2);
            car2.Make = "BMW";
            car2.Color = "White";
            car2.Number = "EB 123456";

            Console.WriteLine(car2);
        }
    }
}
