using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var book = new Book
            {
                Title = "CLR via C#",
                Author = "Jeffrey Richter",
                Pages = 823
            };

            book.TitleChanged += TitleChanged1;
            book.TitleChanged += TitleChanged2;
          
            book.Title = "C#";
            book.Title = "CLR via C#";

            Console.ReadLine();

        }

        private static void TitleChanged2(object sender, TitleChangedEventArgs args)
        {
            Console.WriteLine("********************");
        }

        private static void TitleChanged1(object sender, TitleChangedEventArgs args)
        {
            Console.WriteLine(args.OldValue + " TO" + args.NewValue);
        }
    }
}
