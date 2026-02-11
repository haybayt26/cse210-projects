


public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public Address()
    {
        
    }


    public bool IsUSA()
    ///If USA shipping cost is $5, Not it is $35
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAddress()
    {
        return $"{_street} {_city}, {_state} {_country}";
    }
}