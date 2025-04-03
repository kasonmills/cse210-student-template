using System;

namespace events;

class Address
{
    protected string _address;
    public Address(string address)
    {
        _address = address;
    }

    public string GetAddress(string address)
    {
        return address;
    }

    public void SetAddress()
    {
        // I am not too sure if I even need this method
    }
}