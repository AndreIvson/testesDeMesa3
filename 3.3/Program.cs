using System;

class Program
{
    static void Main()
    {
        double valorFuturo = 0;
        double saque = 0;
        double rendimentoMes = 0;

        Console.WriteLine("Digite o valor a ser investido:");
        double valorPresente = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Qual a taxa de juros? use formato:(0,00)");
        double taxaJuros = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.WriteLine("Quanto tempo vai ficar investido?");
        double periodo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Qual o mês do saque?");
        double mesSaque = Convert.ToDouble(Console.ReadLine());

        if (mesSaque > periodo)
        {
            Console.WriteLine("O mês de saque não pode ser maior que o período de investimento.");
            Console.WriteLine("Quanto tempo vai ficar investido?");
            periodo = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o mês do saque?");
            mesSaque = double.Parse(Console.ReadLine());
        }
        if (mesSaque > periodo)
        {
            Console.WriteLine("O mês de saque continua inválido, operação finalizada.");
            return;
        }

        Console.WriteLine($"|  Mês |      Valor presente      | Taxa de juros |   rendimento do mês   |    Saque    |   Saldo total   |");

        for (int i = 1; i <= periodo; i++)
        {
            rendimentoMes = valorPresente * taxaJuros;
            valorFuturo = valorPresente + rendimentoMes;

            if (i == mesSaque)
            {
                Console.WriteLine($"Quanto você deseja sacar? valor disponivel: {valorPresente:C}");
                saque = double.Parse(Console.ReadLine());
                valorFuturo -= saque;

                Console.WriteLine($"|  {i:D2}  |        {valorPresente:C}       |     {taxaJuros * 100}%        |       {rendimentoMes:C}        |  {saque:C}    |   {valorFuturo:C}   |");
            } else 
            {
                Console.WriteLine($"|  {i:D2}  |        {valorPresente:C}       |     {taxaJuros * 100}%        |       {rendimentoMes:C}        |  {saque = 0:C}    |   {valorFuturo:C}   |");
            }

            valorPresente = valorFuturo;
        }
    }
}