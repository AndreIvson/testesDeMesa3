using System;

class Investimento
{
    private double valorPresente;
    private double taxaJuros;
    private double periodo;
    private double mesSaque;

    public Investimento(double valorPresente, double taxaJuros, double periodo, double mesSaque)
    {
        this.valorPresente = valorPresente;
        this.taxaJuros = taxaJuros / 100;
        this.periodo = periodo;
        this.mesSaque = mesSaque;
    }

    public void SimularInvestimento()
    {
        double valorFuturo = 0;
        double rendimentoMes = 0;

        Console.WriteLine($"|  Mês |    Valor P.   | Taxa %  |  RendMes   |   Saque   | Saldo Total |");

        for (int i = 1; i <= periodo; i++)
        {
            rendimentoMes = valorPresente * taxaJuros;
            valorFuturo = valorPresente + rendimentoMes;

            if (i == mesSaque)
            {
                Console.WriteLine($"Quanto você deseja sacar? valor disponível: {valorPresente:C}");
                double saque = Convert.ToDouble(Console.ReadLine());
                valorFuturo -= saque;

                Console.WriteLine($"|  {i:D2}  |  {valorPresente:C}  |  {taxaJuros * 100:F2}%  |  {rendimentoMes:C}  |  {saque:C}  |  {valorFuturo:C}|");
            }
            else
            {
                Console.WriteLine($"|  {i:D2}  |  {valorPresente:C}  |  {taxaJuros * 100:F2}%  |  {rendimentoMes:C}  |  {0:C}  |  {valorFuturo:C}|");
            }

            valorPresente = valorFuturo;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o valor a ser investido:");
        double valorPresente = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Qual a taxa de juros? use formato:(0,00)");
        double taxaJuros = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Quanto tempo vai ficar investido? (em meses)");
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

        Investimento investimento = new Investimento(valorPresente, taxaJuros, periodo, mesSaque);
        investimento.SimularInvestimento();
    }
}