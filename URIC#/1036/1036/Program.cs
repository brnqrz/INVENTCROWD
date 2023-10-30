using System;
using System.Globalization;
class URI1036
{
    static void Main(string[] args)
    {
        string ENTRADA;
        double A, B, C, DELTA, R1, R2;

        ENTRADA = Console.ReadLine();
        var NUM = ENTRADA.Split(' ');

        A = double.Parse(NUM[0], CultureInfo.InvariantCulture);
        B = double.Parse(NUM[1], CultureInfo.InvariantCulture);
        C = double.Parse(NUM[2], CultureInfo.InvariantCulture);

        DELTA = (B * B) - 4 * A * C;
        R1 = (-B + Math.Sqrt(DELTA)) / (2 * A);
        R2 = (-B - Math.Sqrt(DELTA)) / (2 * A);

        if (DELTA < 0 || A == 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            Console.WriteLine($"R1 = {R1.ToString("F5", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"R2 = {R2.ToString("F5", CultureInfo.InvariantCulture)}");
        }
        Console.ReadKey();
    }
}