using System;
using System.Xml;
using System.Xml.Linq;

namespace Application8
{
    class Program
    {
        static void Main(string[] args)
        {
            using (XmlReader reader = XmlReader.Create("books.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        Console.WriteLine("Element: {0}", reader.Name);


                        string attribute = reader["id"];
                        if (attribute != null)
                        {
                            Console.WriteLine(reader.Name + " element has attribute id: " + attribute);
                        }
                    }
                }
            }

            Console.ReadKey();

            XmlReader r = XmlReader.Create("books.xml");
            while (r.NodeType != XmlNodeType.Element)
                r.Read();
            XElement e = XElement.Load(r);
            Console.WriteLine(e);

            Console.ReadKey();

            /**
             * The streaming .NET XML APIs (which support XmlReader and XmlWriter),
             * which never attempt to hold the whole document in memory—you work one element at a time, 
             * and while that enables you to handle very large documents without using much memory.
             **/
        }
    }
}