using System;
using System.Xml.Linq;

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerXml = new XDocument();

            var rootElement = new XElement("Customers");

            customerXml.Add(rootElement);

            var customerElement = new XElement("Customer");

            var firstNameElement = new XElement("FirstName", "Scott");
            customerElement.Add(firstNameElement);

            var lastNameElement = new XElement("LastName", "Damain");
            customerElement.Add(lastNameElement);

            var emailAddressElement = new XElement("EmailAddress", "scott@abc.com");
            customerElement.Add(emailAddressElement);

            rootElement.Add(customerElement);

            Console.WriteLine(customerXml.ToString());

            Console.ReadKey();
        }
    }
}
