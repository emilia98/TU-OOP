using System;
using System.Linq;

namespace Problem_01_Rectangle
{
    public class Rectangle <T>
    {
        // field
        private T a;

        // field
        private T b;

        private string[] allowedTypes = new string[]
        {
            "Int32",
            "Single",
            "Double"
        };

        public T A
        {
            get { return this.a; }
            set { this.a = value; }
        }

        public T B
        {
            get { return this.b; }
            set { this.b = value; }
        }

        public Rectangle()
        {
            Console.Write("a = ");
            this.A = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.Write("b = ");
            this.B = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
        }

        public Rectangle(T a, T b)
        {
            this.A = a;
            this.B = b;
        }

        
        public void Area()
        {
            string typeName = typeof(T).Name;

            if(!this.allowedTypes.Any(x => x == typeName))
            {
                Console.WriteLine($"Cannot execute this on type {typeName}");
                return;
            }

            switch(typeName)
            {
                case "Int32":
                    {
                        int a = (int)Convert.ChangeType(this.A, typeof(int));
                        int b = (int)Convert.ChangeType(this.B, typeof(int));
                        Console.WriteLine($"Area = {a * b}");
                        break;
                    }
                    
                case "Single":
                    {
                        float a = (float)Convert.ChangeType(this.A, typeof(float));
                        float b = (float)Convert.ChangeType(this.B, typeof(float));
                        Console.WriteLine($"Area = {a * b}");
                        break;
                    }
                case "Double":
                    {
                        double a = (double)Convert.ChangeType(this.A, typeof(double));
                        double b = (double)Convert.ChangeType(this.B, typeof(double));
                        Console.WriteLine($"Area = {a * b}");
                        break;
                    }
            }
        }
        
    }
}
