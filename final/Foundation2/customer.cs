using System;

namespace Orders;

class Customer
{
    /*
    this class needs to be focused on three different things. Whether or not the customer is in the U.S., the name of the customer, and the address of the customer.
    */

    public string _CustomerName;
    Address _address = new Address(address, );


    public Customer(string name, Address address)
    {
        _CustomerName = name;
        _address = address;
    }

    public void GetName()
    {
        _CustomerName = "Veronica Tibbits";
    }

    public string SetName()
    {
        return _CustomerName;
    }

    public void GetAddress()
    {
        _address_ = _address._address;
    }

    public string SetAddress()
    {
        return _address_;
    }

    public bool LivesInUS()
    {
        return true;
    }
}