using System;

namespace Problem_02_Array
{
    public class Array <T>
    {
        // field
        private T[] array;

        public Array(int size)
        {
            this.array = new T[size];
        }

        public void Input()
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                Console.Write($"array[{i}] = ");
                this.array[i] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            }
        }

        public T GetElement(int index)
        {
            if(!IsInArray(index))
            {
                Console.WriteLine("Index outside of bounds of the array");
                return default(T);
            }

            return this.array[index];
        }

        public void ChangeElement(int index, T value)
        {
            if(index < 0 || index >= this.array.Length)
            {
                Console.WriteLine("Index outside of bounds of the array");
                return;
            }

            this.array[index] = value;
        }

        public void Output()
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {this.array[i]}");
            }
            Console.WriteLine();
        }

        private bool IsInArray(int index)
        {
            return !(index < 0 || index >= this.array.Length);
        }
    }
}
