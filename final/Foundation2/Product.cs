public class Product
{
    private string _productName;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string productName, string productId, decimal price)
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

    public void SetPrice(decimal price)
    {
        _price = price;
    }

    public decimal GetPrice()
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