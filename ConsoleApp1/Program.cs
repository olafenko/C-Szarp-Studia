using System;

class Test
{

    static void Main(String[] args)
    {

        int[] arr = new int[20];

        Random random = new Random();

        for (int i = 0;i < 20; i++)
        {
            arr[i] = random.Next(100);
        }

        foreach (int x in arr)
        {
            Console.Write("{0,5}",x);

        }

        Console.WriteLine();    
        int j = 0;
        while (j < 20)
        {


            if (arr[j] % 2 == 0)
            {
                Console.Write("{0,5}", arr[j]);
            }
            j++;

        }





    }

}

