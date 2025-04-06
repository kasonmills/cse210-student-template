using System;

namespace Orders;

class Address
{
    /*
    this class only has to worry about formatting the address and whether or not they live in the USA.
    */

    public string _street;
    public string _city;
    public string _state;
    public string _zipCode;
    public string _country;
    public bool _InUS;

    public Address(string street, string city, string state, string country, string zipCode)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _zipCode = zipCode;
    }

    public string GetStreet()
    {
        return _street;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string GetZipCode()
    {
        return _zipCode;
    }

    public string GetAddress()
    {
        return GetStreet() + " " + GetCity() + " " + GetState() + ", " + GetCountry() + " " +GetZipCode();
    }

    public bool IsUS(string _country)
    {
        if(_country.Contains("USA"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}