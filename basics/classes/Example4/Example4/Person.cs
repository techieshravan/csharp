using System;

namespace Example4
{
    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine(string.Format("Hello {0} {1} your age is {2} years!", FirstName, LastName, Age));
        }
    }
}
