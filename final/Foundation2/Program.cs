using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Address address = new Address("177A Bleecker Street", "New York City", "NY", "USA-Earth 616");
        Customer customer = new Customer("Stephen Vincent Strange", address);
        
        Order order1 = new Order(customer);
        Product item1 = new Product("Cloak of Levitation","E-616CLK110",29.74m);
        item1.SetQuantity(3);
        order1.AddToCart(item1);
        Product item2 = new Product("Sling Ring","E-616RNG000",39.99m);
        item1.SetQuantity(1);
        order1.AddToCart(item2);
        Product item3 = new Product("Eye of Agamotto","E-616AML032",9.60m);
        item1.SetQuantity(3);
        order1.AddToCart(item3);
        orders.Add(order1);

        address = new Address("177A Washington Street", "Baltimore", "MD", "USA");
        customer = new Customer("Vivien Theodore Thomas", address);
        
        Order order2 = new Order(customer);
        item1 = new Product("16.5cm Atraumatic Vascular Clamps","CLMPAT165",1.00m);
        item1.SetQuantity(24);
        order2.AddToCart(item1);
        item2 = new Product("125mm Cardiovascular Clamp","CLMPC125",55.54m);
        item2.SetQuantity(6);
        order2.AddToCart(item2);
        item3 = new Product("14cm Angled Cardio Multi-purpose Clamp","CLMPMP140A",385.11m);
        item3.SetQuantity(3);
        order2.AddToCart(item3);
        orders.Add(order2);

        foreach (Order order in orders)
        {
            Console.Write("\nDescription:\n");
            order.GetPackingLabel();
            Console.WriteLine($"\nTotal Number of Items: {order.CountItems()}"); // Stretch
            Console.WriteLine($"Total Price: {order.CalculateTotalPrice():C}");
            Console.WriteLine($"\nShip To:\n{order.GetShippingLabel()}");
            Console.WriteLine("-------------------------------------------------------------");
        }
        
    }
}