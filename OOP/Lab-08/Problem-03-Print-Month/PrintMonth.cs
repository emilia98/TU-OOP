using System;

namespace Problem_03_Print_Month
{
    class PrintMonth
    {
        static void Main()
        {
            string[] months = new string[]
            {
                "January", "February", "March",
                "April", "May", "June",
                "July", "August", "September",
                "October", "November", "December"
            };

            Console.Write("Month = ");
            int month = int.Parse(Console.ReadLine());

            try
            {
                if(month < 1 || month > 12)
                {
                    throw new IndexOutOfRangeException("Invalid month!");

                }

                Console.WriteLine($"{month} => {months[month - 1]}");
            }
            catch(IndexOutOfRangeException ex)
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
