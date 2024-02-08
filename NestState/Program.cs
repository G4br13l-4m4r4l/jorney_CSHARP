using System;
namespace NestState;

class Program
{
    static void Main(string[] args)
    {
        int sair = 0;
        while (sair != 1)
        {
            Console.Write("Digite quantas colunas: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite quantas linhas: ");
            int l = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Simbolo: ");
            char symbol = Convert.ToChar(Console.ReadLine());

            for(int i = 0; i < c; i++)
            {
                for(int j = 0; j < l; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Deseja continuar? (s/n)");
            String resp = Console.ReadLine();
            if (resp == "n")
            {
                Console.WriteLine("___saindo___");
                sair++;
            }
            Console.Beep();
        }

        Console.ReadKey();
    }
}