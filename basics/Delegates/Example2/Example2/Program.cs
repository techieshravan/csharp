using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    delegate int MathOperation(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            //method group conversion
            MathOperation addition = Addition;
            int result = addition(5, 2);

            Console.Write(result);

            Console.ReadKey();
        }

        static int Addition(int a, int b)
        {
            return a + b;
        }
    }
}
