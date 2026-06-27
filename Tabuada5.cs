// Projeto criado apenas para fins academicos.

// Projeto Tabuada 

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número para tabuada:");
        int numero = int.Parse(Console.ReadLine());

        for (int count = 1; count <= 10; count++)
        {
            Console.WriteLine($"{numero} x {count} = {numero * count}");
        }
    }
}