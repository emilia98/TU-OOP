using System;

namespace Problem_03_Print_Month_2
{
    class PrintNumber2
    {
        static void Main()
        {
            Console.Write("Month = ");
            int month = int.Parse(Console.ReadLine());

            try
            {
                if (month < 1 || month > 12)
                {
                    throw new IndexOutOfRangeException("Invalid month!");

                }

                Console.WriteLine($"{month} => {(Months)month}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch
            {
                Console.WriteLine("Another exception has occurred!");
            }
        }
    }
}
