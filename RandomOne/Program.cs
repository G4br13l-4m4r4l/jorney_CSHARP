using System;
namespace RandomOne;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();//instanciando o aleatório

        Console.WriteLine("Número aleatório: "+ random.Next(1, 21));
        Console.WriteLine("Número aleatório: " + random.Next(1, 21));
        Console.WriteLine("Número aleatório: " + random.Next(1, 21));

        Console.Beep();
        Console.ReadKey();
    }
}