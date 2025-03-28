using System;

namespace Orders;

class Product
{
    /*
    This class will have to keep track of the different products involves with an individual order. It will also have to handle repeat items and repeat customers. this class will also contain
    the list of all products available and that will help with a lot for the future of this project.
    */

    public string _ProdName;
    public string _ID;
    public double _Price;
    public double _Quantity;

    public Product(string name, string id, double price, double amount)
    {
        _ProdName = name;
        _ID = id;
        _Price = price;
        _Quantity = amount;
    }

    public string GetProductName()
    {
        return _ProdName;
    }

    private void SetProductName()
    {
        _ProdName = _ProdName;
    }   

    public string GetID()
    {
        return _ID;
    }

    private void SetID()
    {
        _ID = _ID;
    }

    public double GetPrice()
    {
        return _Price;
    }

    private void SetPrice()
    {
        _Price = _Price;
    }

    public double GetAmount()
    {
        return _Quantity;
    }

    private void SetAmount()
    {
        _Quantity = _Quantity;
    }
}