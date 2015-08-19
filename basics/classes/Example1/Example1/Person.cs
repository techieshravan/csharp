namespace Example1
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
    }
}
