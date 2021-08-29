using System;

namespace OlaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Digite seu nome: ");
            Console.ResetColor();
            Nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Olá ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(Nome);
            Console.ResetColor();
            Console.WriteLine("! Seja bem vindo!");
            Console.WriteLine();
        }
    }
}
