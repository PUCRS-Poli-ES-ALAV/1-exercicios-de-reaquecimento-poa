//* 1. Desenvolva algoritmos recursivos para os seguintes problemas e implemente-os (em Java, por exemplo):
//*    1. Cálculo de 1 + 1/2 + 1/3 + 1/4 + ... + 1/N.
using System;

public class SomaPartesDe1
{
    public static void Main(string[] args)
    {
        //* Comando para rodar: dotnet run --property:StartupObject=SomaPartesDe1
        Console.WriteLine("Vamos calcular a soma de 1 + 1/2 + 1/3 + ... + 1/N usando recursão.");
        Console.WriteLine("Digite o valor de N:");
        int n = int.Parse(Console.ReadLine());
        double resultado = Calcular(n);
        Console.WriteLine($"A soma de 1 + 1/2 + ... + 1/{n} é aproximadamente {resultado}");
    }

    public static double Calcular(int n)
    {
        if (n == 1)
        {
            Console.WriteLine($"Fim da recursão: n é igual a 1, retornando 1");
            return 1;
        }

        Console.WriteLine($"Chamada recursiva: n = {n}");
        return 1 / (double)n + Calcular(n - 1);
    }
    
        //* Exemplo de execução para n = 2:
        //* 1 + 1/2 - 1ª recursão: chama de novo Calcular com n = 1
        //* 1 + 1/2 - 2ª recursão: retorna 1, pois n == 1, e somando com 1/2 do resultado da recursão anterior, retorna 1.5
}