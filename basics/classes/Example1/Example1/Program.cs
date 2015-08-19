using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            person1.FirstName = "Shravan";
            person1.LastName = "Kasagoni";
            person1.Age = 26;

            Console.WriteLine("Person Name: " + person1.FirstName + " " + person1.LastName);
            Console.WriteLine("Person Age: " + person1.Age);

            Console.ReadLine();
        }
    }
}
