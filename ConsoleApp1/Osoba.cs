using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

internal class Osoba
{
    internal string name;
    public string surname;
    short height;
    protected float weight;
    private bool woman;


    public Osoba(string name,string surname,short height,float weight,bool women)
    {
        this.name = name;
        this.surname = surname;
        this.height = height;
        this.weight = weight;
        this.woman = women;
    }

    public Osoba(string n,string s)
    {
        name = n;
        surname = s;
    }

    public void print()
    {

        Console.WriteLine("Osoba {4}, {0} {1}, ma {2} cm wzrostu i wazy {3} kg."
                            ,name,surname,height,weight, woman ? "woman" : "men");

    }


}

