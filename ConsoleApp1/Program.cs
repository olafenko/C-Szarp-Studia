using System;

class Test
{

    static void Main(String[] args)
    {

        Console.Write("Podaj range postaci: ");
        string s = Console.ReadLine();

        byte poziom = 0;

        switch (s)
        {
            case "szaman": poziom += 20; goto case "wojownik";
            case "wojownik":
            case "ninja": poziom += 30; break;
            case "sura": poziom = 40; goto case "szaman";
            default: Console.WriteLine("Nie ma takiej rangi"); break;
        }

        Console.WriteLine($"Lvl postaci to: {poziom}");
        Console.ReadLine();

    }

}

