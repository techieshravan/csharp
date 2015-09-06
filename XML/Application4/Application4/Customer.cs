namespace Application4
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CustomerId { get; set; }
        public string Phone { get; internal set; }
    }
}