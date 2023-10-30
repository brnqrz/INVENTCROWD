using System;
using System.Globalization;
class URI1012
{
    static void Main(string[] args)
    {
        string ENTRADA;
        double A, B, C;
        double AREA_TRIANGULO, AREA_CIRCULO, AREA_TRAPEZIO, AREA_QUADRADO, AREA_RETANGULO;

        ENTRADA = Console.ReadLine();
        var NUM = ENTRADA.Split(' ');

        A = double.Parse(NUM[0], CultureInfo.InvariantCulture);
        B = double.Parse(NUM[1], CultureInfo.InvariantCulture);
        C = double.Parse(NUM[2], CultureInfo.InvariantCulture);

        AREA_TRIANGULO = (A * C)/2;
        AREA_CIRCULO = 3.14159 * (C * C);
        AREA_TRAPEZIO = ((A + B) * C)/2;
        AREA_QUADRADO = (B * B);
        AREA_RETANGULO = (A * B);

        Console.WriteLine($"TRIANGULO: {AREA_TRIANGULO.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"CIRCULO: {AREA_CIRCULO.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"TRAPEZIO: {AREA_TRAPEZIO.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"QUADRADO: {AREA_QUADRADO.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"RETANGULO: {AREA_RETANGULO.ToString("F3", CultureInfo.InvariantCulture)}");
    }
}