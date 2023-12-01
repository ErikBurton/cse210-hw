// Creates a class that represents an address with street, city, state/province, and country
class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    // Constructor for creating an address
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    // Checks if the address is in the USA
    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    // Overrides the ToString method to get the formatted address string
    public override string ToString()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }
}