using System;

namespace Example11Output_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            var number = Convert.ToInt16(Console.ReadLine());

            double rootValue;

            var result = TrySqrt(number, out rootValue);

            if(result)
            {
                Console.Write("Square Root of {0} is {1}" , number, rootValue);
            }
            else
            {
                Console.Write("input number should be greater than zero!");
            }

            Console.ReadLine();

            Console.Write("Enter your age: ");

            string input = Console.ReadLine();

            int age;

            if (!int.TryParse(input, out age))
                Console.Write("Invaild input for age");
            else
                Console.Write("Valid age");

            Console.ReadKey();
        }

        static bool TrySqrt(int input, out double root)
        {
            root = 0.0;

            if (input < 0)
                return false;

            root = Math.Sqrt(input);

            return true;
        }
    }
}
