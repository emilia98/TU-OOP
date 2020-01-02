using System;

namespace Problem_02_Array
{
    class StartUp
    {
        static void Main()
        {
            Array<string> arr_1 = new Array<string>(3);
            arr_1.Input();
            Console.WriteLine();
            arr_1.Output();
            arr_1.ChangeElement(2, "Hello");
            arr_1.Output();

            Array<int> arr_2 = new Array<int>(5);
            arr_2.Input();
            Console.WriteLine();
            arr_2.Output();
            arr_2.ChangeElement(-1, 3);
            arr_2.ChangeElement(1, 10);
            arr_2.Output();

            Array<double> arr_3 = new Array<double>(4);
            arr_3.Input();
            Console.WriteLine();
            arr_3.Output();
            arr_3.ChangeElement(5, 1.11);
            arr_3.ChangeElement(2, -17.53);
            arr_3.Output();
        }
    }
}
