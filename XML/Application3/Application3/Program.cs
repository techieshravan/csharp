using System;
using System.Xml.Linq;

namespace Application3
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

            var fullAddressElement = new XElement("FullAddress");

            var addressElement = new XElement("Address", "2732 Baker Blvd.");
            fullAddressElement.Add(addressElement);

            var cityElement = new XElement("City", "Eugene");
            fullAddressElement.Add(cityElement);

            var regionElement = new XElement("Region", "OR");
            fullAddressElement.Add(regionElement);

            var postalCodeElement = new XElement("PostalCode", "97403");
            fullAddressElement.Add(postalCodeElement);

            var countryElement = new XElement("Country", "USA");
            fullAddressElement.Add(countryElement);

            customerElement.Add(fullAddressElement);

            var customerIdAttribute = new XAttribute("CustomerId", "CUST0001");
            customerElement.Add(customerIdAttribute);

            var phoneAttribute = new XAttribute("Phone", "(503) 555-6874");
            customerElement.Add(phoneAttribute);

            rootElement.Add(customerElement);

            Console.WriteLine(customerXml.ToString());

            Console.ReadKey();
        }
    }
}
