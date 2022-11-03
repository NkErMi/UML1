using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Menukort
{
    private string _pizza;
    private string _drinks;

    public string Pizza
    {
        get { return _pizza; }
    }
    public string Drinks
    {
        get { return _drinks; }
    }


    public Menukort(string Pizza, string Drinks)
    {
        _pizza = Pizza;
        _drinks = Drinks;
    }

    public override string ToString()
    {
        return "Pizzaen på menukort er: " + Pizza + " and" + Drinks;
    }
}
