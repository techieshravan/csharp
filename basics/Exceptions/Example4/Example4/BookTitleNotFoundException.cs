using System;

namespace Example4
{
    public class BookTitleNotFoundException : Exception
    {
        public BookTitleNotFoundException()
        {
            Console.WriteLine("Book Title Not Found");
        }

        public BookTitleNotFoundException(string message) : base(message)
        {
            Console.WriteLine(message);
        }

        public BookTitleNotFoundException(string message, Exception inner): base(message, inner)
        {
            Console.WriteLine(message);
        }
    }
}
