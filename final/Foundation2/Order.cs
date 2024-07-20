public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double TotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetPrice() * product.GetQuantity();
        }

        if (_customer.IsLocalCust())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public void PackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetProductName()}: {product.GetProductId()}");
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine($"{_customer.GetName()} \n{_customer.GetAddress()}");
    }
}