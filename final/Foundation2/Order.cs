// Class to represent an order containing products and a customer
class Order
{
    private List<Product> _products;
    private Customer _customer;

// Constructor for creating an order with a customer
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Add a product to the order
    // Encapsulation: Private list of products
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculates the total price of the order, including shipping cost
    // Encapsulation: Getter for private list of products
    public List<Product> GetProducts()
    {
        return _products;
    }

    // Encapsulation: Getter for private customer
    public Customer GetCustomer()
    {
        return _customer;
    }


    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (var product in _products)
        {
            totalPrice += product.GetTotalPrice();
        }

        // Add shipping cost based on customer location
        if (_customer.IsInUSA())
            totalPrice += 5.00;
        else
            totalPrice += 35.00;

        return totalPrice;
    }

    // Generates a packing label string for the order
    public string GetPackingLabel()
    {
        string label = "";
        foreach (var product in _products)
        {
            // Encapsulation: Using getters for product properties
            label += $"Product: {product.Name}, ID: {product.ProductId}\n";
        }
        return label;
    }

    // Generates a shipping label string for the order
    public string GetShippingLabel()
    {
        // Encapsulation: Using getters for customer properties
        return $"Customer: {_customer.Name}\n{_customer.GetAddressString()}";
    }
}