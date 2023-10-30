using System;

class URI1848
{
    static void Main(string[] args)
    {
        string GRITO;
        int LOTERIA;

        for (int i = 0; i<3; i++)
        {
            LOTERIA = 0;
            while (true)
            {
                GRITO = Console.ReadLine();
                if (GRITO[0] == '*') LOTERIA += 4;
                if (GRITO[1] == '*') LOTERIA += 2;
                if (GRITO[2] == '*') LOTERIA += 1;

                if (GRITO[0] >= 'c') break;
            }
            Console.WriteLine(LOTERIA);
        }

    }
}
