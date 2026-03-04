//* 1. Desenvolva algoritmos recursivos para os seguintes problemas e implemente-os (em Java, por exemplo):
//*    1. Inversão de uma string.
using System;

public class InversaoString
{
    public static void Main(string[] args)
    {
        //* Comando para rodar: dotnet run --property:StartupObject=InversaoString
        Console.WriteLine("Vamos inverter uma string usando recursão.");
        Console.WriteLine("Digite a string:");
        string input = Console.ReadLine();
        string resultado = Inverte(input);
        Console.WriteLine($"A string invertida é: {resultado}");
    }

    public static string Inverte(string s)
    {
        if (s.Length <= 1)
        {
            Console.WriteLine($"Fim da recursão: string é '{s}', retornando '{s}'");
            return s;
        }

        Console.WriteLine($"Chamada recursiva: string = '{s}'");
        
    }
}