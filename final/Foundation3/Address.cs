// Address class represents location details of an event
class Address
{
    // Properties to store address components
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }

    // Constructor to initialize address properties
    public Address(string _street, string _city, string _state, string _zipCode)
    {
        Street = _street;
        City = _city; 
        State = _state;
        ZipCode = _zipCode;
    }

    // Override ToStirng method to format the address as a string
    public override string ToString()
    {
        return $"{Street}, {City}, {State}, {ZipCode}"; // Return formated string
    }
}