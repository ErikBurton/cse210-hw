// Creates a class that epresents a customer with a name and an address
class Customer
{
    private string _name;
    private Address _address;

    // Constructor for creating a customer with an address
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Checks if the customer is in the USA
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // Property for accessing customer name
    public string Name { get { return _name; } }

    // Gets the formatted address string for the customer
    public string GetAddressString()
    {
        return _address.ToString();
    }
}