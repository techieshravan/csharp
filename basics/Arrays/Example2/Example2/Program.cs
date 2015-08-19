using System;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing Arrays

            int[] numbers1 = new int[5] { 1, 2, 3, 4, 5 };
            string[] names1 = new string[3] { "one", "two", "three" };

            //You can omit the size of the array:

            int[] numbers2 = new int[] { 1, 2, 3, 4, 5 };
            string[] names2 = new string[] { "one", "two", "three" };

            // Multidimensional Array

            int[,] numbers3 = new int[3, 2] 
            { 
                { 1, 2 }, 
                { 3, 4 }, 
                { 5, 6 }
            };
            
            string[,] siblings1 = new string[2, 2] 
            { 
                { "Mike", "Amy" }, 
                { "Mary", "Albert" }
            };

            //You can omit the size of the array, like this:

            int[,] numbers4 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            string[,] siblings2 = new string[,] { { "Mike", "Amy" }, { "Mary", "Albert" } };

            // You can also omit the new operator

            int[] numbers5 = { 1, 2, 3, 4, 5, 6 };

            string[] names3 =  { "one", "two", "three", "four" };

            int[,] numbers6 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            string[,] siblings3 = { { "Mike", "Amy" }, { "Mary", "Albert" } };

            //print the values

            Console.WriteLine(numbers1[3]);

            Console.WriteLine(names1[2]);

            Console.WriteLine(numbers3[2,1]);

            Console.WriteLine("===FOR EACH===");

            foreach (int i in numbers1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("===FOR EACH===");
            int[,] numbers7 = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
            foreach (int i in numbers7)
            {
                Console.Write("{0} ", i);
            }
            
            Console.Write(Environment.NewLine + "Array Length: " + names1.Length);

            Console.ReadKey();
        }
    }
}
