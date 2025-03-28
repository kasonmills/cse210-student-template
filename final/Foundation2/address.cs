using System;

namespace Orders;

class Address
{
    /*
    this class only has to worry about formatting the address and whether or not they live in the USA.
    */

    public string _address;
    public bool _InUS;

    public Address(string address, bool inUS)
    {
        _address = address;
        _InUS = inUS;
    }

    private void SetAddress()
    {
        _address = "1234 west st, USA 0000";
    }

    public string GetAddress()
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