using System;

namespace Orders;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        // this class needs a list of orders to read off to for the other classes
        Order order= new Order();
        order.AddToOrder();
        order.DisplayShippingLabel();
        order.DisplayPackingItems();
        double total = order.CalculateOrderTotal();
        Console.WriteLine($"Your order total is ${total}");
    }
}