using System;

namespace Example3
{
    class Person
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private byte _age;

        public byte Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public void SayName()
        {
            var name = string.Format("Name: {0} {1}", _firstName, _lastName);

            Console.WriteLine(name);
        }

        public void SayAge()
        {   
            Console.WriteLine("Age: " + _age);
        }
    }
}
