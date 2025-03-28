using System;

namespace Orders;
class Order
{
    /*
    so this class needs several things. first it needs to know the cost of each item. Second it needs to know what customers are involved. Third to be involved with a whole list of different
    kinds of product. Then there needs to be a method that will calculate the overall cost of each item.
    */
    Customer customer = new Customer(string name, Address address);

    public List<Product> _products = new List<Product>();
    Product product1 = new Product("Hot Dogs","hd14", 1.34, 3);
    Product product2 = new Product("Red Grapes","rg55", .37, 12);
    Product product3 = new Product("TV Dinner","td18", 4.85, 2);
    Product product4 = new Product("Salmon","S475", 18.72, 2);
    Product product5 = new Product("BaseBall","BB843", 11.10, 16);

    public double CalculateOrderTotal()
    {
        double total = 0;
        double PriceOfUnits;
        double Shipping = CalulateShippingCost();
        foreach(Product tot in _products)
        {
            PriceOfUnits = tot._Price * tot._Quantity;
            total += PriceOfUnits;
        }
        total += Shipping;
        return total;
    }

    public double CalulateShippingCost()
    {
        if(customer.LivesInUS())
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
        Console.WriteLine($"{customer._CustomerName}\n{customer.GetAddress()}");
    }

    public void AddToOrder()
    {
        _products.Add(product1);
        _products.Add(product2);
        _products.Add(product3);
        _products.Add(product4);
        _products.Add(product5);
    }
}
