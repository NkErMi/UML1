using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Store
{
    public void Start()
    {
        Pizza pizza = new Pizza("Naples", "tomato, cheese, anchovies, olives", 120);
        Customer customer = new Customer("Klaus Andersen", "klausandersen@gmail.com", "40234522", "Svalevej 22");
        Order order = new Order(pizza, customer);

        Console.WriteLine(customer);
        Console.WriteLine();
        Console.WriteLine($"The total cost of the order is {order.CalculateTotalPrice()} " + "kr. " + $"It includes a pizza with tomato, cheese and ham. " + $"Price is: {(pizza.Price + 40) * 1.25}" + $" Order will be delivered to {customer} ");
        Console.WriteLine();


        Pizza pizza2 = new Pizza("Vesuvio", "tomato, cheese and ham", 75);

        Customer customer2 = new Customer("Nina Kristensen", "ninakristensen@outlook.com", "22553476", "Gadehjørnet 23");
        Console.WriteLine(customer2);
        Console.WriteLine();

        Order order2 = new Order(pizza2, customer2);
        Console.WriteLine($"The total cost of the order is {order2.CalculateTotalPrice()} " + "kr. " + $"It includes a pizza with tomato, cheese and ham. " + $"Price is: {(pizza2.Price + 40) * 1.25}" + $" Order will be delivered to {customer2}");

        Pizza pizza3 = new Pizza("Marinara", "tomato, cheese, ham, mushrooms, shrimp and peppers", 85);
        Customer customer3 = new Customer("Alex Jansen", "alexjansen@gmail.com", "23254689", "Koldingvej 23");
        Order order3 = new Order(pizza3, customer3);

        Console.WriteLine();
        Console.WriteLine(customer3);
        Console.WriteLine();
        Console.WriteLine($"The total cost of the order is {order3.CalculateTotalPrice()} " + "kr. " + $"It includes a pizza with tomato, cheese and ham. " + $"Price is: {(pizza3.Price + 40) * 1.25}" + $" order will be delivered to {customer3}");

    }
}
