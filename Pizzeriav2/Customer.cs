using Pizzeriav2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Customer
{
    private string _name;
    private string _email;
    private string _tlfnr;
    private string _adresse;

    public string Name
    {
        get { return _name; }
    }

    public string Email
    {
        get { return _email; }
    }

    public string Tlfnr
    {
        get { return _tlfnr; }
    }

    public string Adresse
    {
        get { return _adresse; }
    }

    public Customer(string name, string email, string tlfnr, string adresse)
    {
        _name = name;
        _email = email;
        _tlfnr = tlfnr;
        _adresse = adresse;

        CustomerRegistry.List.Add(this);
    }

    public override string ToString()
    {
        return Name + " contact details is " + Email + ", " + Tlfnr + " and " + Adresse;
    }
}
