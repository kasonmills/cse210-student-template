using System;

namespace product;
class Order
{
    /*
    so this class needs several things. first it needs to know the cost of each item. Second it needs to know what customers are involved. Third to be involved with a whole list of different
    kinds of product. Then there needs to be a method that will calculate the overall cost of each item.
    */
    
    public string _CustomerName;

    public List<Products> products = new List<Products>();
    public Address address = new Address();
    public Order()
    {

    }

    public double CalculateOrderTotal()
    {
        return 0;
    }

    public bool LivesInUS()
    {
        return false;
    }

    public void DisplayPackingItems()
    {

    }

    public void DisplayShippingLabel()
    {

    }
}
