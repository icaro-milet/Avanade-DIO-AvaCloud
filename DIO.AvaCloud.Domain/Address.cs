namespace DIO.AvaCloud.Domain
{
    public enum AddressType
    {
        Comercial = 1,
        Residential = 2
    }

    public class Address
    {
        public int AddressId { get; set; }

        public AddressType AddressType { get; set; }

        public string City { get; set; }

        public string PostCode { get; set; }

        public string StreetName { get; set; }

        public string State { get; set; }

        public string Number { get; set; }

        public string Complement { get; set; }


        public bool Validate() => !string.IsNullOrWhiteSpace(PostCode);

    }
}
