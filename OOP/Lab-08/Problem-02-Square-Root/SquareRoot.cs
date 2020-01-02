using System;

namespace Problem_02_Square_Root
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                double a = double.Parse(Console.ReadLine());

                if(a <= 0)
                {
                    throw new FormatException("Invalid number!");
                }

                double result = Math.Sqrt(a);

                Console.WriteLine($"Result = {result}");
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("End of program");
            }
        }
    }
}
