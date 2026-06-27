// Projeto criado apenas para fins academicos.

// Projeto MaiorMenor  



using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine($"O maior número é: {num1}");
        }
        
        else if (num1 == num2)
        {
            Console.WriteLine("Os números são iguais.");
        }
    }
}