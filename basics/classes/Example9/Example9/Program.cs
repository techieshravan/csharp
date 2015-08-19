using System;

namespace Example9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---pass by value---");

            int a = 5;

            Console.WriteLine("a value in main before calling foo1: " + a);

            Foo1(a); //pass by value

            Console.WriteLine("a value in main after calling foo1: " + a);

            Console.ReadKey();

            Console.WriteLine("---pass by reference---");

            var person = new Person { FirstName = "Shravan", LastName = "Kasagoni", Age = 21 };

            Console.WriteLine("Person Age in main before calling foo2: " + person.Age);

            Foo2(person);  //pass by reference

            Console.WriteLine("Person Age in main after calling foo2: " + person.Age);

            Console.ReadKey();
        }

        private static void Foo1(int a)
        {
            Console.WriteLine("a in foo1 before increment: " + a);
            a++;
            Console.WriteLine("a in foo1 after increment: " + a);
        }

        private static void Foo2(Person x)
        {
            Console.WriteLine("Person Age in foo2 before increment: " + x.Age);
            x.Age++;
            Console.WriteLine("Person Age in foo2 after increment: " + x.Age);
        }

    }
}
