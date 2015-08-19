using System;

namespace Example10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            Console.WriteLine("a value in main before calling foo1: " + a);

            Foo1(ref a);

            Console.WriteLine("a value in main after calling foo1: " + a);

            Console.ReadKey();
        }

        private static void Foo1(ref int x)
        {
            Console.WriteLine("a in foo1 before increment: " + x);
            x++;
            Console.WriteLine("a in foo1 after increment: " + x);
        }
    }
}
