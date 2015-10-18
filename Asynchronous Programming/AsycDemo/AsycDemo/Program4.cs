using System;
using System.Diagnostics;
using System.Net;

namespace ConsoleApplication1
{
    //APM - Asynchronous Programming Model - C#5.0
    class Program4
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

            var task = wc.DownloadStringTaskAsync("http://theshravan.net"); // this will start downloading 

            /*
                these lines will start executing after staring download, independent of download process and
                return the control to main incase if the download is not completed even after execution of these lines
            */

            Debug.WriteLine("I am doing something before await called");
            
            data = await task; // this line and  following lines will execute only after downloading completes 

            Debug.WriteLine("After await called");

            Debug.WriteLine("--------------------------------------");

            Debug.WriteLine("Data has been downloaded");
            
            Console.WriteLine(data);

            Debug.WriteLine("--------------------------------------");
        }
    }
}
