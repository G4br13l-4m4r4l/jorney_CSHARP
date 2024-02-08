using System;
namespace Hypotenuse;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double result = Math.Sqrt(Math.Pow(a, 2)+ Math.Pow(b, 2));

        Console.WriteLine("Hipotenusa é: " + result);
        Console.Beep();
        Console.ReadKey();
    }
}