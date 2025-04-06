using System;

namespace Orders;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        // this class needs a list of orders to read off to for the other classes

        // customer one
        List<Product> products = new List<Product>();
        
        Address _address = new Address("117 W. 34 S.", "Deer Passage", "WA", "USA", "41843");
        string address = _address.GetAddress();
        string _country = _address.GetCountry();
        bool _whatCountry = _address.IsUS(_country);

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
        double shipping = order.CalculateShippingCost(_whatCountry);
        decimal total = ((decimal)order.CalculateOrderTotal(shipping));
        order.DisplayShippingLabel(customer._CustomerName, address);
        order.DisplayPackingItems();
        Console.WriteLine(total + "\n");

        // order two
        List<Product> products2= new List<Product>();
        
        Address _address2 = new Address("8431 S. Wishtta", "Sap Springs", "Nebraska", "Canada", "843188");
        string address2 = _address2.GetAddress();
        string _country2 = _address2.GetCountry();
        bool _whatCountry2 = _address2.IsUS(_country2);

        Customer customer2 = new Customer("Sophie Turner", address2);

        Product product6 = new Product("Lenovo phone charger","LC17A", 5.17, 2);
        Product product7 = new Product("Laptop holding case","H3O11", 35.47, 1);
        Product product8 = new Product("wall adapter","7L47C", 3.21, 8);
        Product product9 = new Product("Frying Pan","878SS", 26.41, 4);
        Product product10 = new Product("Bounce Back","DF18T", 375.16, 1);

        products2.Add(product6);
        products2.Add(product7);
        products2.Add(product8);
        products2.Add(product9);
        products2.Add(product10);

        Order order2 = new Order(products2);
        double shipping2 = order2.CalculateShippingCost(_whatCountry2);
        decimal total2 = ((decimal)order2.CalculateOrderTotal(shipping2));
        order2.DisplayShippingLabel(customer2._CustomerName, address2);
        order2.DisplayPackingItems();
        Console.WriteLine(total2);
    }
}