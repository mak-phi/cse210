public class Address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;

    public Address(string street, string city, string province, string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
    }

    /* public void SetStreet(string street)
    {
        _street = street;
    }

    public string GetStreet()
    {
        return _street;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetProvince(string province)
    {
        _province = province;
    }

    public string GetProvince()
    {
        return _province;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    public string GetCountry()
    {
        return _country;
    } */

    public bool IsUSAAddress()
    {
        if (_country.ToUpper() == "USA" || _country.ToUpper() == "UNITED STATES OF AMERICA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAddressString()
    {
        return $"\t{_street}\n\t{_city}, {_province}\n\t{_country}";
    }

}