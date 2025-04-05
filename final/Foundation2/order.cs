using System;

namespace Orders;
class Order
{
    /*
    so this class needs several things. first it needs to know the cost of each item. Second it needs to know what customers are involved. Third to be involved with a whole list of different
    kinds of product. Then there needs to be a method that will calculate the overall cost of each item.
    */
    public List<Product> _products = new List<Product>();
    public Order(List<Product> products)
    {
        _products = products;
    }

    public double CalculateOrderTotal()
    {
        double total = 0;
        double PriceOfUnits;
        double Shipping = CalculateShippingCost();
        foreach(Product tot in _products)
        {
            PriceOfUnits = tot._Price * tot._Quantity;
            total += PriceOfUnits;
        }
        total += Shipping;
        return total;
    }

    public double CalculateShippingCost()
    {
        Customer customer = new Customer();
        if()
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
        foreach(Product prod in _products)
        {
            Console.WriteLine($"{prod._ProdName} {prod._ID}");
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine($"{customer._CustomerName}\n{customer.add}");
    }
}
