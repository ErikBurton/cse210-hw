// Address class represents location details of an event
class Address
{
    // Properties to store address components
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }

    // Constructor to initialize address properties
    public Address(string street, string city, string state, string zipCode)
    {
        Street = street;
        City = city; 
        State = state;
        ZipCode = zipCode;
    }

    // Override ToStirng method to format the address as a string
    public override string ToString()
    {
        return $"{Street}, {City}, {State}, {ZipCode}"; // Return formated string
    }
}