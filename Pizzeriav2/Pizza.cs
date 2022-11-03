using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pizza
{

    private string _name;
    private string _topping;
    private int _price;



    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Topping
    {
        get { return _topping; }
        set { _topping = value; }
    }

    public int Price

    {
        get { return _price; }
        set { _price = value; }
    }



    public Pizza(string Name, string Topping, int Price)
    {
        _name = Name;
        _topping = Topping;
        _price = Price;
    }

    public override string ToString()
    {
        return Name + " with " + Topping + " " + Price;
    }

}

