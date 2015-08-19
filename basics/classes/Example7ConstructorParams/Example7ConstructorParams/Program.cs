using System;

namespace Example7ConstructorParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi t = new Taxi(false);

            var result = t.IsInitialized ? "YES" : "NO";

            Console.WriteLine("Is Taxi Ready? : " + result);

            Console.ReadLine();
        }
    }
}
