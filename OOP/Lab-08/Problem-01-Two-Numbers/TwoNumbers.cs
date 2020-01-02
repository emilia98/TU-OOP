using System;

namespace Problem_01_Two_Numbers
{
    class TwoNumbers
    {
        static void Main()
        {
            try
            {
                Console.Write("a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine());

                int result = a / b;

                Console.WriteLine($"Result = {result}");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Enter a valid integer number!");
                Console.WriteLine(ex.StackTrace);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                // Console.WriteLine("Cannot divide by zero!");
                Console.WriteLine(ex.StackTrace);
            }
            catch
            {
                Console.WriteLine("Unknown exception has been thrown!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
