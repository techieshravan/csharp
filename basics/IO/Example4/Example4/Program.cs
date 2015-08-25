using System;
using System.IO;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        { 
            foreach (var path in Directory.EnumerateFiles("C:\\"))
            {
                Console.WriteLine(path);
            }

            string[] paths = Directory.GetFiles("C:\\");
            foreach (string path in paths)
            {
                Console.WriteLine(path);
            }


            if (Directory.Exists("C:\\Users"))
            {
                Console.WriteLine("Users");
            }
            if (Directory.Exists("C:\\Temp"))
            {
                Console.WriteLine("Temp");
            }
            
            // Get info.
            DirectoryInfo info = new DirectoryInfo(@"E:\GitHub\");
            
            Console.WriteLine(info.Name);
            
            FileInfo[] array = info.GetFiles();
            Console.WriteLine(array.Length);

            Console.ReadKey();
        }
    }
}
