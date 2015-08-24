using System;
using System.Collections;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashTbl = new Hashtable();

            hashTbl.Add("Shravan", 26);
            hashTbl["Pranav"] = 62;

            bool shravanIsKnown = hashTbl.ContainsKey("Shravan");
            Console.WriteLine(shravanIsKnown);
            bool someIsAged62 = hashTbl.ContainsValue(62);
            Console.WriteLine(someIsAged62);
            
            foreach (string name in hashTbl.Keys)
                Console.WriteLine("Age of {0} is {1}", name, hashTbl[name]);

            hashTbl.Remove("Shravan");

            foreach (string name in hashTbl.Keys)
                Console.WriteLine("Age of {0} is {1}", name, hashTbl[name]);

            Console.ReadLine();
        }
    }
}
