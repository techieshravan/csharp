using System;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            Console.Write("Enter First Name: ");
            person1.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person1.LastName = Console.ReadLine();

            Console.Write("Enter Age: ");
            person1.Age = Convert.ToByte(Console.ReadLine());

            person1.SayName();
            person1.SayAge();

            Console.ReadLine();
        }
    }
}
