// Projeto criado apenas para fins academicos.

// Projeto: NotasAluno 


using System;

public class Program
{
    public static void Main(string[] args)
    {
        float nota1;
        Console.WriteLine("Digite a primeira nota:");
        nota1 = float.Parse(Console.ReadLine());

        float nota2;
        Console.WriteLine("Digite a segunda nota:");
        nota2 = float.Parse(Console.ReadLine());

        float nota3;
        Console.WriteLine("Digite a terceira nota:");
        nota3 = float.Parse(Console.ReadLine());

        float media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine("A média das notas é: " + media.ToString("F1"));

        if (media >= 7)
        {
            Console.WriteLine("Aprovado");
        }
        else if (media <= 6.9 && media >= 5)
        {
            Console.WriteLine("Recuperação");
        }
        else if (media < 5)
        {
            Console.WriteLine("Reprovado");
        }   
    }
}