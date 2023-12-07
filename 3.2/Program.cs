using System;

class program 
{
    static void Main()
    {
        double valorPresente = 0;
        double taxaJuros = 0;
        double periodo = 5;
        double periodoPosSaque = 3.33;
        double valorFuturo = 0;
        double saque = 0;
        double rendimento = 0;
        double valorPresenteAtualizado = 0;
        double valorFuturoFinal = 0;

        Console.WriteLine("Digite o valor a ser investido:");
        valorPresente = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual a taxa de juros? use formato:(0,00)");
        taxaJuros = double.Parse(Console.ReadLine()) / 100;

        valorFuturo = valorPresente * Math.Pow((1 + taxaJuros), periodo);

        rendimento = valorFuturo - valorPresente;

        saque = rendimento;

        valorPresenteAtualizado = valorFuturo - saque;

        valorFuturoFinal = valorPresenteAtualizado * Math.Pow((1 + taxaJuros), periodoPosSaque);
            
        Console.WriteLine($"O valor futuro em 5 meses será: {valorFuturo:C}");
        Console.WriteLine($"O valor do saque é: {saque:C}");
        Console.WriteLine($"O valor presente pós saque é: {valorPresenteAtualizado:C}");
        Console.WriteLine($"O valor ao final dos 8 meses e 10 dias será: {valorFuturoFinal:C}");
    }
}