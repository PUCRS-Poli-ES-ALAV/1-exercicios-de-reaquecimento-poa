//* 1. Desenvolva algoritmos recursivos para os seguintes problemas e implemente-os (em Java, por exemplo):
//*    1. Soma de dois números naturais, através de incrementos sucessivos (Ex.: 3 + 2 = + + (+ + + 1)).

using System;

public class Soma
{
    public static void Main(string[] args)
    {
        //* Comando para rodar: dotnet run --property:StartupObject=Soma
        Console.WriteLine("Vamos calcular a soma de dois números naturais usando incrementos sucessivos.");
        Console.WriteLine("Digite o número a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número b:");
        int b = int.Parse(Console.ReadLine());
        int resultado = Somar(a, b);
        Console.WriteLine($"{a} + {b} = {resultado}");
    }

    public static int Somar(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine($"Fim da recursão: b é igual a 0, retornando a = {a}");
            return a;
        }

        Console.WriteLine($"Chamada recursiva: a = {a}, b = {b}");
        return 1 + Somar(a, b - 1);
    }

    //* Exemplo de execução para a = 10 e b = 5:
    //* 10+5 - 1ª recursão: chama de novo Somar com a = 10 e b = 4
    //* 10+5 - 2ª recursão: chama de novo Somar com a = 10 e b = 3
    //* 10+5 - 3ª recursão: chama de novo Somar com a = 10 e b = 2
    //* 10+5 - 4ª recursão: chama de novo Somar com a = 10 e b = 1
    //* 10+5 - 5ª recursão: chama de novo Somar com a = 10 e b = 0
    //* 10+5 - 6ª recursão: retorna a (10), pois b == 0, e somando com os 1+ do resultado das recursões anteriores, da 15
}