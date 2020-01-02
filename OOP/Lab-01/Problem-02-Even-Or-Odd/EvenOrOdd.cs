using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02_Even_Or_Odd
{
    class EvenOrOdd
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int reminder = a % 2;

            if (reminder == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
