using System;
using System.Linq;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 1, 2, 3, 4, 5 };

            var evens1 = numbers.Where(delegate (int i) { return i % 2 == 0; });
            var odds1 = numbers.Where(delegate (int i) { return i % 2 != 0; });
            
            // Lambda Expressions

            var evens2 = numbers.Where(i => i % 2 == 0);
            var odds2 = numbers.Where(i => i % 2 != 0);

            Console.ReadLine();
        }
    }
}
