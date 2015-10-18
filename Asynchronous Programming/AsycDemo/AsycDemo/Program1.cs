using System;
using System.Diagnostics;
using System.Net;

namespace ConsoleApplication1
{
    class Program1
    {
        static void Main(string[] args)
        {

            Debug.WriteLine("Before calling download method");

            DownloadData();

            Debug.WriteLine("After calling download method");

            Console.ReadKey();
        }

        private static void DownloadData()
        {
            WebClient wc = new WebClient();

            string data;

            data  = wc.DownloadString("http://theshravan.net");

            Debug.WriteLine("Data has been downloaded");

            Console.WriteLine(data);
        }
    }
}
