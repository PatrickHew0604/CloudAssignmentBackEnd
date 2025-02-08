namespace CloudAssignment_BackEnd.Models.Domain
{
    public class Address
    {
        public Guid AddressID { get; set; }
        public string PostalCode { get; set; }

        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }

        public string City { get; set; }
        public string State { get; set; }
    }
}
