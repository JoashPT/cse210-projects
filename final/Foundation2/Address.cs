public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsInUS()
    {
        if (_country == "US" || _country == "USA")
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
        return $"{_street} {_city} \n{_stateProvince}, {_country}";
    }
}