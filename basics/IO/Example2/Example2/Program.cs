using System;
using System.IO;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray1 = { "C#", "JAVA", "C++" };
            File.WriteAllLines(@"D:\File2.txt", stringArray1);
            
            Console.ReadKey();

            string[] stringArray2 = { "SWIFT", "RUBY", "PYTHON" };
            File.WriteAllLines(@"D:\File2.txt", stringArray2);

            Console.ReadKey();

            File.AppendAllText(@"D:\File2.txt", string.Format("{0}Line Two{0}", Environment.NewLine)); 
            File.AppendAllText(@"D:\File2.txt", "Line Three");

            Console.ReadKey();
            
            File.WriteAllText(@"D:\File3.txt", "This is HelloWorld File! This is HelloWorld File! ");

            Console.ReadKey();
        }
    }
}
