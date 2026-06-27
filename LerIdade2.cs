// Projeto criado apenas para fins academicos.

// Projeto LerIdade 




using System;

public class Program
{
    public static void Main(string[] args)
    {
        int idade;
        Console.WriteLine("Qual a sua idade?");
        idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade.");
        }
        else
        {
            Console.WriteLine("Você é menor de idade.");
        }
     }


}