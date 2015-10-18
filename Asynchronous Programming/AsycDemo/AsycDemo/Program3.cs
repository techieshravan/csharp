using System;
using System.Diagnostics;
using System.Net;

namespace ConsoleApplication1
{
    //APM - Asynchronous Programming Model - C#5.0
    class Program3
    {
        static void Main(string[] args)
        {

            Debug.WriteLine("Before calling download method");

            DownloadData();

            Debug.WriteLine("After calling download method");

            Console.ReadKey();
        }

        private async static void DownloadData()
        {

            Debug.WriteLine("Download method invoked....");

            WebClient wc = new WebClient();

            string data;

            data = await wc.DownloadStringTaskAsync("http://theshravan.net"); // following lines will execute only after downloading completes 

            Debug.WriteLine("--------------------------------------");

            Debug.WriteLine("Data has been downloaded");
            
            Console.WriteLine(data);

            Debug.WriteLine("--------------------------------------");
        }
    }
}
