using System;

namespace Orders;
class Order
{
    /*
    so this class needs several things. first it needs to know the cost of each item. Second it needs to know what customers are involved. Third to be involved with a whole list of different
    kinds of product. Then there needs to be a method that will calculate the overall cost of each item.
    */
    Customer customer = new Customer();

    public List<Product> products = new List<Product>();
    public Order()
    {

    }

    public double CalculateOrderTotal()
    {
        return 0;
    }

    public double CalulateShippingCost()
    {
        if(customer._address[1])
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public void DisplayPackingItems()
    {
        foreach(Product prod in products)
        {
            Console.WriteLine($"{prod._ProdName} {prod._ID}");
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine($"{customer._CustomerName}\n{customer._address}");
    }
}
