using System;
using System.IO;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = null;
            var fileinfo = new FileInfo("TextFile1.txt");
            try
            {
                file = fileinfo.OpenWrite();
                file.WriteByte(0xF);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Could not locate the file");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                // Check for null because OpenWrite might have failed. 
                if (file != null)
                {
                    file.Close();
                }
            }

            Console.ReadKey();
        }
    }
}
