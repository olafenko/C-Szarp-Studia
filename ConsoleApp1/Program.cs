using System;

class Test
{

    static void Main(String[] args)
    {

        Console.WriteLine("TABLICA REGULARNA\n");
        //TABLICE REGULARNE

        //tablica dwuwymiarowa,  najpierw liczba wierszy, potem kolumn
        int[,] arr;

        arr = new int[5, 5];

        //inicjalizacja losowymi wartosciami
        Random rand = new Random(); 
        for(int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                arr[i, j] = rand.Next(100);
            }
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write("{0,5}",arr[i, j]);
            }
            Console.WriteLine();
        }


        //dablica trójwymiarowa, najpierw liczba warstw, wierszy, kolumn
        int[,,] arr2 = new int[10, 5, 2];


        //TABLICE NIEREGULARNE
        Console.WriteLine("\nTABLICA NIEREGULARNA\n");

        //tzw. tablica tablic, dla kazdego wiersza inicjujemy osobno tablice z liczba wartosci ktora chcemy
        int[][] arr3 = new int[4][];
        

        for (int i = 0;i< 4; i++)
        {

            arr3[i] = new int[i + 1];
            
            for(int j = 0; j < arr3[i].Length; j++)
            {
                arr3[i][j] = rand.Next(100);
            }

        }

        foreach (int[] x in arr3)
        {
            foreach (int y in x)
            {
                Console.Write("{0,5}", y);
            }
            Console.WriteLine();
        }

        //operacje na tablicach inne

        Console.WriteLine("\nOPERACJE NA TABLICACH\n");

        string[] mowiPawel = { "Elo","Siemka","Dzień dobry","Cześć","Witaj"};

        int choice = rand.Next(mowiPawel.Length);
        Console.WriteLine($"Pawel: {mowiPawel[choice]}");

        string[] mowiGawel = (string[])mowiPawel.Clone();

        choice = rand.Next(mowiPawel.Length);
        Console.WriteLine($"Gawel: {mowiGawel[choice]}");

        string[,] towary = { { "Komputer", "6000" },{"Krzeslo","250"},{"Lampa","170"}};
        int towar = rand.Next(towary.GetLength(0));
        Console.WriteLine($"Pawel: Kupuje {towary[towar,0]}");
        Console.WriteLine($"Gawel: Dobra, placisz {int.Parse(towary[towar,1]):c}");


    }

}

