using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Declaring Arrays*/

            int[] table; // not int table[];  


            // Single-dimensional arrays:

            int[] numbers;          // declare numbers as an int array of any size

            numbers = new int[10];  // numbers is a 10-element array

            numbers = new int[20];  // now it's a 20-element array


            // Multidimensional arrays:

            int[,] array = new int[4, 2];

            int[,,] array1 = new int[4, 2, 3];

            string[,] names = new string[2,3];

            // Array-of-arrays (jagged):

            byte[][] scores = new byte[5][];
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = new byte[i + 3];
            }

            // Print length of each row
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
            }

        }
    }
}
