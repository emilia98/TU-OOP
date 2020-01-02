using System;

namespace Problem_03_Months_Days
{
    class Months_Days
    {
        static void Main()
        {
            string[,] monthsData = new string[,]
            {
                { "January",  "31" },
                { "February", "28/29" },
                { "March", "31" },
                { "April", "30" },
                { "May", "31" },
                { "June", "30" },
                { "July", "31" },
                { "August", "31" },
                { "September", "30" },
                { "October", "31" },
                { "November", "30" },
                { "December", "31" },
            };

            for(int i = 0; i < monthsData.GetLength(0); i++)
            {
                Console.WriteLine($"{monthsData[i, 0]} => {monthsData[i, 1]}");
            }
        }
    }
}