using System;

namespace Example8ConstructorParams
{
    class Program
    {
        static void Main(string[] args)
        {
            var coords = new Coordinates(10, 50);

            Console.WriteLine("Coordinates: {0}", coords);

            Console.ReadKey();
        }
    }
}
