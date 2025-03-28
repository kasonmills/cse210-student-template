using System;

namespace Orders;

class Customer
{
    /*
    this class needs to be focused on three different things. Whether or not the customer is in the U.S., the name of the customer, and the address of the customer.
    */

    public string _CustomerName;
    Address _address = new Address();
    public string add;

    public Customer(string name, Address address)
    {
        _CustomerName = name;
        _address = address;
    }
    private void SetName()
    {
        _CustomerName = "Veronica Tibbits";
    }

    public string GetName()
    {
        return _CustomerName;
    }

    private void SetAddress()
    {
        add = _address.GetAddress();
    }

    public string GetAddress()
    {
        return add;
    }

    public bool LivesInUS()
    {
        if(add.Contains("USA"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}