public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public void SetCustomerAddress(Address customerAddress)
    {
        _customerAddress = customerAddress;
    }

    public Address GetCustomerAddress()
    {
        return _customerAddress;
    }
    
    public bool IsUSAAddress()
    {
        return _customerAddress.IsUSAAddress();
    }
}