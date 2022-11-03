using Pizzeriav2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Order
{
    public Pizza Pizza { get; set; }
    public Customer Customer { get; set; }

    public bool IsConfirmed { get; set; }   

    public int Amount { get; set; } 

    public Order(Pizza pizza, Customer customer, int amount)
    {
        Pizza = pizza;
        Customer = customer;

        OrderRegistry.List.Add(this);

        
    }

    public double CalculateTotalPrice()
    {
        int deliveryFee = 40;
        double tax = 1.25;
        double totalPrice = (Pizza.Price + deliveryFee) * tax;

        return totalPrice;
    }

    public override string ToString()
    {
        return Customer + "has ordered " + Pizza;
    }

}
