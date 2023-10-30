using System;
using System.Globalization;
class URI1043
{
    static void Main(string[] args)
    {
        string ENTRADA;
        double A, B, C, AREA, PERIMETRO;

        ENTRADA = Console.ReadLine();
        var NUM = ENTRADA.Split(' ');

        A = double.Parse(NUM[0], CultureInfo.InvariantCulture);
        B = double.Parse(NUM[1], CultureInfo.InvariantCulture);
        C = double.Parse(NUM[2], CultureInfo.InvariantCulture);

        PERIMETRO = A + B + C;
        AREA = ((A + B) * C) / 2;

        if ((B+C> A) && (A+C>B) && (A+B>C))
        {
            Console.WriteLine($"Perimetro = {PERIMETRO.ToString("F1", CultureInfo.InvariantCulture)}");
        }
        else
        {
            Console.WriteLine($"Area = {AREA.ToString("F1", CultureInfo.InvariantCulture)}");
        }
        Console.ReadKey();
    }
}