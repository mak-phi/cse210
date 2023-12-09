public class Product
{
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string productName, string productId, double price)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = 0;
    }

    public void SetProductName(string productName)
    {
        _productName = productName;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public void SetProductId(string productId)
    {
        _productId = productId;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public void SetPrice(double price)
    {
        _price = price;
    }

    public double GetPrice()
    {
        return _price;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}