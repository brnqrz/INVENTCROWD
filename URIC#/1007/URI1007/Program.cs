using System;
class URI1007
{
    static void Main(string[] args)
    {
        int A, B, C, D, DIF;

        A = Convert.ToInt32(Console.ReadLine());
        B = Convert.ToInt32(Console.ReadLine());
        C = Convert.ToInt32(Console.ReadLine());
        D = Convert.ToInt32(Console.ReadLine());

        DIF = ((A * B) - (C * D));

        Console.WriteLine("DIFERENCA = " + DIF);
        Console.ReadKey();
    }
}