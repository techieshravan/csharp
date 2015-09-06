using System.Xml.Serialization;

namespace Application6
{
    public class Customer
    {
        [XmlAttribute]
        public string FirstName { get; set; }
        
        [XmlIgnore]
        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public override string ToString()
        {
            return $"FirstName: {FirstName}\nLastName: {LastName}\nEmail: {EmailAddress}";
        }
    }
}