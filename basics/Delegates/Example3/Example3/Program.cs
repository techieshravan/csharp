using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        delegate int MathOperation(int a, int b);

        static void Main(string[] args)
        {
            //Anonymous Function Expressions

            MathOperation addition = delegate (int a, int b) { return a + b; };
            int three = addition(1, 2); // calls the anonymous method through the delegate
            Console.WriteLine(three);

            //Closures: Captured Outer Variables

            int factor = 2;
            MathOperation additionAndFactor = delegate (int a, int b) { return factor * (a + b); };
            int six = additionAndFactor(1, 2);
            
            Console.WriteLine(six);
            
            Console.ReadLine();
        }
    }
}