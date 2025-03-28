using System;

class Test
{

    static void Main(String[] args)
    {

        Console.Write("Podaj ilosc uzyskanych punktow: ");
        byte points = Convert.ToByte(Console.ReadLine());

        string grade = null;

        grade = points switch
        {
            <= 50 => "2",
            <= 60 => "3",
            <= 70 => "3,5",
            <= 78 => "4",
            <= 86 => "4,5",
            <= 94 => "5",
            > 94 and <=100 => "5,5",
            _ => "nie mozliwe"
        };
       

        Console.WriteLine($"ocena koncowa to: {grade}");
        Console.ReadLine();

    }

}

