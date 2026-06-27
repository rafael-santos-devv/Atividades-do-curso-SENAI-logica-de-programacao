// Projeto criado apenas para fins academicos.

// Projeto ParouImpar 

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é par");
        }
        else
        {
            Console.WriteLine("O número é ímpar");
        }
    }
}