using System;

class Test
{

    static void Main(String[] args)
    {

        //zmienne lokalne;
        string elo = "Cześć";
        int x;
        x = 2;

        //Wypisiwanie na konsole
        Console.WriteLine("Przyklad 1.\n===Wypisywanie na konsole===\n");
        Console.WriteLine("Zmienna x = {0}\n",x);
        Console.WriteLine($"Zmienna x = {x}\n");
        Console.WriteLine($"Zmienna elo = {elo}\n");
        Console.ReadLine();
        Console.Clear();

        //typy zmiennoprzecinkowe
        Console.WriteLine("Przyklad 2.\n==Typy zmiennoprzecinkowe===\n");
        float f_pi = (float) Math.PI;
        decimal d_pi = (decimal) Math.PI;
        Console.WriteLine($"Liczba pi jako float = {f_pi}\nLiczba pi jako decimal = {d_pi}\nLiczba pi jako double = {Math.PI}\n\n");

        //decimal dobry dla precyzyjnosci liczb po przecinku
        decimal large_num = 9.1234567890123456789012345678901234567890m;
        float f_num = (float)large_num;
        double d_num = (double)large_num;
        Console.WriteLine($"(decimal) = {large_num}\n(float) = {f_num}\n(double) = {d_num}\n\n");

        decimal veryLargeNum = 2136213712637213621321312.231329671m;
        Console.WriteLine(veryLargeNum);
        Console.Read();
        Console.Clear();

        //literały tekstowe i znakowe
        Console.WriteLine("Przyklad 3.\n===Literały tekstowe i znakowe===\n");

        string s1 = @"\t\\\\\\\\\";
        string s2 = "\t\\\\\\\\";
        Console.WriteLine($"(string z małpą przed) s1 = {s1}\n(string bez małpy przed) s2 = {s2}\n\n");

        Console.Read();
        Console.Clear();

        //operator checked sprawdzający zakres typu (dla unchecked petla jest nieskonczona)
        //checked jezeli zmienna przekroczy zakres swojego typu wyrzuca wyjatek
        Console.WriteLine("Przyklad 4.\n===Sprawdzanie overflow===\n");

        byte y;
        y = 0;

        try
        {
            while (y < 10000000)
                checked
                {
                    Console.WriteLine($"Liczba to: {y}");
                    y++;
                }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ostateczny wynik to: {y}");
        }

        
        //odczyt z konsoli i konwersja do innego typu i wypisanie
        Console.WriteLine("\n\nPrzyklad 5.\n===Wczytywanie z konsoli i konwersja===\n");
        Console.Write("Podaj liczbe: ");
        var s = Console.ReadLine();
        double d;// var - typ wnioskowany z metody ReadLine, bedzie to string
        d = Convert.ToDouble(s); // konwersja do double
        Console.WriteLine($"Podana liczba to: {d}");
    }

}

