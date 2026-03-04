//* 1. Desenvolva algoritmos recursivos para os seguintes problemas e implemente-os
//*    1. Multiplicação de dois números naturais, através de somas sucessivas (Ex.: 6 ∗ 4 = 4 + 4 + 4 + 4 + 4 + 4).

using System;
public class Multiplicacao
{
    public static void Main(string[] args)
    {
        //* Comando para rodar: dotnet run --property:StartupObject=Multiplicacao
        Console.WriteLine("Vamos calcular a multiplicação de dois números naturais usando somas sucessivas.");
        Console.WriteLine("Digite o numero a:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o numero b:");
        int b = int.Parse(Console.ReadLine());

        int resultado = Multiplicar(a, b);
        Console.WriteLine($"{a} * {b} = {resultado}");
    }

    public static int Multiplicar(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine($"Fim da recursão: b é igual a 0, retornando 0");
            return 0;
        }
        Console.WriteLine($"Chamada recursiva: a = {a}, b = {b}");
        return a + Multiplicar(a, b - 1);
    }

    //* Exemplo de execução para a = 10 e b = 5:
    //* 10*5 - 1ª recursão: chama de novo Multiplicação com a = 10 e b = 4
    //* 10*5 - 2ª recursão: chama de novo Multiplicação com a = 10 e b = 3
    //* 10*5 - 3ª recursão: chama de novo Multiplicação com a = 10 e b = 2
    //* 10*5 - 4ª recursão: chama de novo Multiplicação com a = 10 e b = 1
    //* 10*5 - 5ª recursão: chama de novo Multiplicação com a = 10 e b = 0
    //* 10*5 - 6ª recursão: retorna 0, pois b == 0, e somando o número de recursões anteriores com a (10), da 50
}