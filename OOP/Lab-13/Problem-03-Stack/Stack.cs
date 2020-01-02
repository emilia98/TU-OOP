using System;

namespace Problem_03_Stack
{
    public class Stack <T>
    {
        private T[] stack;
        private int lastUsedIndex;
        private int length;

        public Stack(int size)
        {
            this.stack = new T[size];
            this.lastUsedIndex = -1;
            this.length = size;
        }

        public T Peek()
        {
            if(!this.IsEmpty())
            {
                return this.stack[this.lastUsedIndex];
            }

            return default(T);
        }

        public void Push(T value)
        {
            if(this.IsFull())
            {
                Console.WriteLine("Stack overflow.");
                return;
            }

            this.stack[++lastUsedIndex] = value;
        }

        public bool IsEmpty()
        {
            return this.lastUsedIndex == -1;
        }

        public bool IsFull()
        {
            return this.lastUsedIndex == this.length - 1;
        }
    }
}
