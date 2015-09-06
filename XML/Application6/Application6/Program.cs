using System;
using System.IO;
using System.Xml.Serialization;

namespace Application6
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Customer
            {
                FirstName = "PersonFN1",
                LastName = "PersonLN1",
                EmailAddress = "person1@abc.com"
            };

            var serializer = new XmlSerializer(typeof(Customer));
            var writer = new StringWriter();
            serializer.Serialize(writer, c1);

            string xml = writer.ToString();
            Console.WriteLine("Customer in XML:\n{0}\n", xml);

            Customer c2 = serializer.Deserialize(new StringReader(xml)) as Customer;
            Console.WriteLine("Customer in Object:\n{0}", c2);

            Console.ReadKey();
        }
    }
}
