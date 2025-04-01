using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
class Grupa
{

    public const int MAX_CAPACITY = 24;
    public static readonly int minCapacity;
    public string name = "NONAME";
    public static int numOfGroups;
    public Osoba[] people;

    public Grupa(int liczbaMiejsc,string nazwa)
    {
        people = new Osoba[liczbaMiejsc>MAX_CAPACITY?MAX_CAPACITY:liczbaMiejsc];
        name = nazwa;
        numOfGroups++;

    }


    public Grupa(Osoba[] czlonkowie)
    {
        people = (Osoba[]) czlonkowie.Clone();
        numOfGroups++;
    }

    public Grupa()
    {
        people = new Osoba[minCapacity];
        numOfGroups++;
    }

    static Grupa()
    {
        numOfGroups = 0;
        minCapacity = 6;
        Console.WriteLine("=====Wywolano konstruktor statyczny=====");
    }

    int ileZajetych()
    {
        int x = 0;
        foreach (Osoba o in people)
        {
            if (o != null)
            {
                x++;
            }
        }
        return x;
    }

    public void add(Osoba osoba,int pozycja)
    {

        people[pozycja] = osoba;

    }

    public void print()
    {
        Console.WriteLine("\nNazwa grupy:{0} Numer grupy:{2} Liczba zajetych miejsc:{1}\n",name,ileZajetych(),numOfGroups);
        foreach(Osoba o in people)
        {
            if(o != null)
            {
                o.print();
            }
            else
            {
                Console.WriteLine("FREE SLOT");
            }
            
        }
    }
}
