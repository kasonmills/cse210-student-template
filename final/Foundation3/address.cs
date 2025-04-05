using System;

namespace events;

class Address
{
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
        return GetStreet() + GetCity() + GetState() + GetCountry() + GetZipCode();
    }
}