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
        grupa.add(szef,0);
        grupa.add(pracownik,1);
        grupa.add(osoba1,2);
        grupa.add(osoba2,3);
        grupa.add(osoba3,4);
        grupa.add(osoba4,5);

      
        grupa.print();

    }
}

