using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            const string path = @"D:\File1.txt";

            var extension = Path.GetExtension(path);
            var filename = Path.GetFileName(path);
            var filenameNoExtension = Path.GetFileNameWithoutExtension(path);
            var root = Path.GetPathRoot(path);

            Console.WriteLine("{0}\n{1}\n{2}\n{3}", extension, filename, filenameNoExtension, root);

            Console.ReadKey();

            // Combine two path parts.

            string path1 = Path.Combine("Content", "file.txt");
            Console.WriteLine(path1);
            
            // Same as above
            
            string path2 = Path.Combine("Content\\", "file.txt");
            Console.WriteLine(path2);

            Console.ReadKey();
        }
    }
}
