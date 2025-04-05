using System;

namespace Orders;

class Customer
{
    /*
    this class needs to be focused on three different things. Whether or not the customer is in the U.S., the name of the customer, and the address of the customer.
    */

    public string _CustomerName;
    
    public string add;

    public Customer(string name, string address)
    {
        _CustomerName = name;
        add = address;
    }

    public string GetName()
    {
        return _CustomerName;
    }

    public string GetAddress()
    {
        return add;
    }

    public bool LivesInUS()
    {
        if(_address._InUS)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}