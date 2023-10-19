using System;

namespace Foundation2

{
class Program
{
    static void Main(string[] args)
    {
        List <Order> l1 = new List <Order> ();

        Order o1 = new Order();
        o1.SetCustomer("Stacy Oliverson","100 W 100 S, Idaho Falls, ID,USA");
        o1.SetOrder("Book", "508", 1,1);
        o1.SetOrder("Desk","699",1,1);
        l1.Add(o1);

        Order o2 = new Order();
        o2.SetCustomer("Hayden Hunter", "101 W Belville Oaks Ln, Leland, NC,USA");
        o2.SetOrder("Blanket", "509", 1,1);
        o2.SetOrder("Couch","845", 1,2);
        l1.Add(o2);

        Order o3 = new Order();
        o2.SetCustomer("William Locke", "125 S Carol Ave, Mesa, AZ,USA");
        o2.SetOrder("Yoyo", "795", 1,1);
        o2.SetOrder("Game","743", 1,2);
        l1.Add(o2);

        foreach (Order o in l1)
        {
        /* display packing label */

        Console.WriteLine();
        string packingLabel = o.PackingLabel();
        
        Console.WriteLine(packingLabel);
        Console.WriteLine();

        /* display shipping label */

        string shippingLabel = o.ShippingLabel();
        
        Console.WriteLine (shippingLabel);

        /* display the total price of the order */
        Console.WriteLine($"The total price of the order is: {o.CalculateCostOfOrder()}\n");
        }


    }
}
}