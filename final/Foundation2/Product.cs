// Class to represent a product with a name, ID, price, and quantity
class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor for creating a product
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Calculates the total price of the product based on quantity
    // Encapsulation: Getter for private property
    public double GetTotalPrice()
    {
        return _price * _quantity;
    }

    // Properties for accessing product details
    // Encapsulation: Getter for private property
    public string Name { get { return _name; } }
    public string ProductId { get { return _productId; } }
}