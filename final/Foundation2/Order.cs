public class Order
{
    private Customer _customer;
    private List<Product> _items;
    
    public Order(Customer customer)
    {
        _customer = customer;
        _items = new List<Product>();
    }

    public void AddToCart(Product item)
    {
        _items.Add(item);
    }

    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        decimal shippingCost;

        foreach (Product item in _items)
        {
            totalPrice += (item.GetPrice() * item.GetQuantity());
        }
        if (_customer.IsUSAAddress())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return totalPrice += shippingCost;
    }

    public void GetPackingLabel()
    {
        int i = 1;
        foreach (Product item in _items)
        {
            Console.WriteLine($"{i}. [{item.GetProductId()}] {item.GetProductName()}");
            i++;
        }

    }

    public string GetShippingLabel()
    {
        return $"\t{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress().GetAddressString()}";
    }

    public int CountItems() // Stretch
    {
        int numOfItems = 0;
        foreach (Product item in _items)
        {
            numOfItems += item.GetQuantity();
        }
        return numOfItems;
    }
}