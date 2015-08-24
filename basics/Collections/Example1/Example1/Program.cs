using System;
using System.Collections;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayLst = new ArrayList();

            arrayLst.Add(1);
            PrintArrayList(arrayLst);

            arrayLst.AddRange(new[] { 2, 3, 7, 6, 5, 4 });
            PrintArrayList(arrayLst);

            arrayLst.Insert(index: 0, value: 0);
            PrintArrayList(arrayLst);

            arrayLst.RemoveAt(index: 4);
            PrintArrayList(arrayLst);

            arrayLst.Remove(obj: 1);
            PrintArrayList(arrayLst);

            arrayLst.RemoveRange(index: 2, count: 3);
            PrintArrayList(arrayLst);

            arrayLst.Reverse();
            PrintArrayList(arrayLst);

            arrayLst.Sort();
            PrintArrayList(arrayLst);

            bool hasTwo = arrayLst.Contains(2);
            Console.WriteLine(hasTwo);

            int two = (int)arrayLst[1];
            Console.WriteLine(two);

            Console.ReadLine();
        }

        static void PrintArrayList(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
