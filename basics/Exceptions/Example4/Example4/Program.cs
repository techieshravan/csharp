using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var booksList = new List<Book>
            {
                new Book
                {
                    Title = "Title1",
                    Author = "Author1",
                    Pages = 823
                },
                new Book
                {
                    Title = "Title2",
                    Author = "Author2",
                    Pages = 100
                }
            };

            try
            {
                var found = FindBookByTitle(booksList, "Title3");
                Console.WriteLine(found);
            }
            catch (BookTitleNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        private static bool FindBookByTitle(List<Book> books, string title)
        {
            var book = books.Find(t => t.Title == title);
            if (book != null)
            {
                return true;
            }
            throw new BookTitleNotFoundException();
        }
    }
}