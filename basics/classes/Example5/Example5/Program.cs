using System;

namespace Example5
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            
            Console.WriteLine(calculator.Multiply(10, 20));

            Console.WriteLine(calculator.Subtract(30, 5));

            Console.WriteLine(calculator.Subtract(5, 87));

            Console.WriteLine(calculator.Add(100, 3000000));

            Console.ReadLine();
        }
    }
}
