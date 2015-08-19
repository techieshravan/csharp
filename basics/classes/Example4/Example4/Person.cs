using System;

namespace Example4
{
    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public void SayName()
        {
            var name = string.Format("Name: {0} {1}", FirstName, LastName);

            Console.WriteLine(name);
        }

        public void SayAge()
        {
            Console.WriteLine(Age);
        }
    }
}
