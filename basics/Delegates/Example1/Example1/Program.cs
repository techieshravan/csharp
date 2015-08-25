using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            var add = new MathOperation(Addition);
            int result = add(5, 2);

            Console.Write(result);

            Console.ReadKey();
        }

        static int Addition(int a, int b)
        {
            return a + b;
        }
    }
}
