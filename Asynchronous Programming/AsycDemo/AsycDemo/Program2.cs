using System;
using System.Diagnostics;
using System.Net;

namespace ConsoleApplication1
{
    //APM - Asynchronous Programming Model - C#2.0
    class Program2
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

            wc.DownloadStringAsync(new Uri("http://theshravan.net"));

            wc.DownloadStringCompleted += Wc_DownloadStringCompleted;

            Debug.WriteLine("After calling download string async method");
            
        }

        private static void Wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            Debug.WriteLine("Data has been downloaded");
            Console.WriteLine(e.Result);
        }
    }
}
