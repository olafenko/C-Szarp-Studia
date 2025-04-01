using ConsoleApp1;

class Test
{

    static void Main(String[] args)
    {
        Osoba szef = new Osoba("Jan", "Kowalski", 180, 75.3f, false);
        
        Osoba pracownik = new Osoba("Kasia","Nowak",160,59.4f,true);
        szef.print();
        pracownik.print();

        Osoba osoba1 = new Osoba("John", "Doe", 188, 95.3f, false);
        Osoba osoba2 = new Osoba("Sam", "Potato", 168, 65.8f, true);
        Osoba osoba3 = new Osoba("Mike", "Tyson", 188, 85.5f, false);
        Osoba osoba4 = new Osoba("Kanye", "Tomato", 170, 77.1f, false);

        //Console.WriteLine($"Osoba to: {osoba.name} {osoba.surname}");

        Grupa grupa = new Grupa(10,"Dział IT");
        //bez parametru opcjonalnego, przymjie wartosc domyslna czyli 0
        grupa.add(szef);
        grupa.add(pracownik,1);
        grupa.add(osoba1,2);
        //parametry nazwane
        grupa.add(pozycja: 3, osoba:osoba2);
        grupa.add(osoba3,4);
        grupa.add(osoba4,5);

      
        grupa.print();

    }
}

