using System;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            person1.FirstName = "Shravan";
            person1.LastName = "Kasagoni";
            person1.Age = 26;

            person1.SayName();
            person1.SayAge();

            Console.ReadLine();
        }
    }
}
