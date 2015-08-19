using System;

namespace Example6Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi t = new Taxi();

            var result = t.IsInitialized ? "YES" : "NO";

            Console.WriteLine("Is Taxi Ready? : " + result);
            
            Console.ReadLine();
        }
    }
}
