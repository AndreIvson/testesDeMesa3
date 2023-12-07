using System;

class Program 
{
    static void Main()
    {
        double valorPresente = 0;
        double taxaJuros = 0;
        double periodo = 8.33;
        double valorFuturo = 0;

        Console.WriteLine("Digite o valor a ser investido:");
        valorPresente = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual a taxa de juros? use formato:(0,00)");
        taxaJuros = double.Parse(Console.ReadLine()) / 100;

        valorFuturo = valorPresente * Math.Pow((1 + taxaJuros), periodo);

        Console.WriteLine($"O valor futuro em 8 meses e 10 dias será: {valorFuturo:C}");
    }
}
