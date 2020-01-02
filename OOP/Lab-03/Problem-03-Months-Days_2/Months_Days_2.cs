using System;

namespace Problem_03_Months_Days_2
{
    class Months_Days_2
    {
        static void Main()
        {
            string[][] monthsData = new string[12][];

            string[] months = new string[]
            {
                "January",
                "Febraury",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December",
            };

            string[] days = new string[]
            {
                "31",
                "28/29",
                "31",
                "30",
                "31",
                "30",
                "31",
                "31",
                "30",
                "31",
                "30",
                "31",
            };

            for(int i = 0; i < months.Length; i++)
            {
                monthsData[i] = new string[2];
                monthsData[i][0] = months[i];
                monthsData[i][1] = days[i];
            }

            foreach(string[] monthDay in monthsData)
            {
                Console.WriteLine($"{monthDay[0]} => {monthDay[1]}");
            }
        }
    }
}
