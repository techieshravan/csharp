using System;
using System.Collections;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue1 = new Queue();

            queue1.Enqueue(new Person("Shravan", 10));
            queue1.Enqueue(new Person("Pranav", 38));
            queue1.Enqueue(new Person("Raj", 60));

            var shravan = (Person)queue1.Dequeue();
            var pranav = (Person)queue1.Peek();

            int itemsLeft1 = queue1.Count;
            
            Console.ReadLine();
            
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            var three = (int)stack.Pop();
            var two = (int)stack.Peek();
            var itemsLeft2 = stack.Count;

            Console.ReadLine();
        }

        static void Print<T>(T t)
        {
            foreach (var item in t)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
