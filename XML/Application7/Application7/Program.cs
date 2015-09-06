using System;
using System.Xml.Linq;

namespace Application7
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Parsing XML from String\n");

            var xml = @"<Contacts>
                            <Contact>
                                <Name>Patrick Hines</Name>
                                <Phone Type=""home"">206-555-0144</Phone>
                                <Phone type=""work"">425-555-0145</Phone>
                                <Address>
                                <Street1>123 Main St</Street1>
                                <City>Mercer Island</City>
                                <State>WA</State>
                                <Postal>68042</Postal>
                                </Address>
                                <NetWorth>10</NetWorth>
                            </Contact>
                            <Contact>
                                <Name>Gretchen Rivas</Name>
                                <Phone Type=""mobile"">206-555-0163</Phone>
                                <Address>
                                <Street1>123 Main St</Street1>
                                <City>Mercer Island</City>
                                <State>WA</State>
                                <Postal>68042</Postal>
                                </Address>
                                <NetWorth>11</NetWorth>
                            </Contact>
                        </Contacts>";
            
            XElement contacts = XElement.Parse(xml);
            Console.WriteLine(contacts);

            Console.ReadKey();

            Console.WriteLine("\nLoad XML from a File\n");
            XElement booksFromFile = XElement.Load(@"books.xml");
            Console.WriteLine(booksFromFile);

            Console.ReadKey();
        }
    }
}
