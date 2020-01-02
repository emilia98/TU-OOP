using System;
using System.Collections;

namespace Problem_01_ArrayList
{
    class StartUp
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();

            Console.Write("x = ");
            arrayList.Add(int.Parse(Console.ReadLine()));
            arrayList.Add(12);

            Random rnd = new Random();

            for (int i = 0; i < 8; i++)
            {
                arrayList.Add(rnd.Next(1, 100));
            }

            foreach (int item in arrayList)
            {
                Console.WriteLine(item);
            }

            arrayList.Remove(12);
            arrayList.RemoveAt(4);

            Console.WriteLine(new string('*', 15));
            Console.WriteLine("After removal:");

            arrayList.Sort();

            for (int i = 0; i < arrayList.Count; i++)
            {
                int item = (int)arrayList[i];
                Console.WriteLine(item);
            }
        }
    }
}
