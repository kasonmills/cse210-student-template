using System;

namespace Orders;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        // this class needs a list of orders to read off to for the other classes
        List<Product> products= new List<Product>();
        
        Address _address = new Address("117 W. 34 S.", "Deer Passage", "WA", "USA", "41843");
        string address = _address.GetAddress();

        Customer customer = new Customer("Veronica Johnson", address);

        Product product1 = new Product("Hot Dogs","hd14", 1.34, 3);
        Product product2 = new Product("Red Grapes","rg55", .37, 12);
        Product product3 = new Product("TV Dinner","td18", 4.85, 2);
        Product product4 = new Product("Salmon","S475", 18.72, 2);
        Product product5 = new Product("BaseBall","BB843", 11.10, 16);

        products.Add(product1);
        products.Add(product2);
        products.Add(product3);
        products.Add(product4);
        products.Add(product5);

        Order order= new Order(products);
    }
}