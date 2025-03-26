using System;

namespace Orders;

class Address
{
    /*
    this class only has to worry about formatting the address and whether or not they live in the USA.
    */

    public string _address;
    public bool _InUS;

    public Address(string address, bool InUS)
    {
        // this constructor might be redundant but I don't know yet.
        _address = address;
        _InUS = InUS;
    }

    public void GetAddress()
    {
        _address = "1234 west st, USA";
    }

    public string SetAddress()
    {
        return _address;
    }

    public bool IsAddressUS(string _address)
    {
        if(_address.Contains("USA"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}