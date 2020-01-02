using System;

namespace Problem_04_Time
{
    class PrintTime
    {
        static void Main()
        {
            try
            {
                Time time = new Time();

                Console.Write("Hours = ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Minutes = ");
                int minutes = int.Parse(Console.ReadLine());
                Console.Write("Seconds = ");
                int seconds = int.Parse(Console.ReadLine());

                time.Hour = hours;
                time.Minute = minutes;
                time.Second = seconds;

                Console.WriteLine($"Time: {time.Hour:d2}:{time.Minute:d2}:{time.Second:d2}");
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
