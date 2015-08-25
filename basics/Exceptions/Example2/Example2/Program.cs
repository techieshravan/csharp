using System;
using System.ComponentModel;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book
            {
                Title = "CLR via C#",
                Author = "Jeffrey Richter",
                Pages = 823
            };

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(book))
            {
                Console.WriteLine("{0} = {1}", descriptor.Name, descriptor.GetValue(book));
            }

            try
            {
                Console.Write("Enter book title: ");
                book.Title = Console.ReadLine();
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine("Invaild book title");
            }
            
            Console.ReadKey();
        }
    }
}
