using System;

namespace getMathApp;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite outro número inteiro: ");
        int b = Convert.ToInt32(Console.ReadLine());

        double c = Math.Pow(a, b);

        Console.WriteLine("resultado: " + c);
        Console.Beep();
        Console.ReadKey();
    }
}