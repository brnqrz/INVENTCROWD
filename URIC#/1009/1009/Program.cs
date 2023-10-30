using System;
using System.Globalization;
class URI1009
{
    static void Main(string[] args)
    {
        string NOME;
        double SALARIO_BASE, VENDAS_MENSAL, SALARIO_TOTAL;

        NOME = Console.ReadLine();
        SALARIO_BASE = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        VENDAS_MENSAL = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        SALARIO_TOTAL = SALARIO_BASE + (VENDAS_MENSAL * 0.15);

        Console.WriteLine($"TOTAL = R$ {SALARIO_TOTAL.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.ReadKey();
    }
}