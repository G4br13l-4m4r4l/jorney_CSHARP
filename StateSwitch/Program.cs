using System;
namespace StateSwitch;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um dia:");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day) { 
            case 0:
                Console.WriteLine("é domingo!");
                break;
            case 1:
                Console.WriteLine("é segunda");
                break;
            case 2:
                Console.WriteLine("é terça");
                break;
            case 3:
                Console.WriteLine("é quarta");
                break;
            case 4:
                Console.WriteLine("é quinta");
                break;
            case 5:
                Console.WriteLine("é sexta");
                break;
            case 6:
                Console.WriteLine("é sabado");
                break;
            default:
                Console.WriteLine(day + " não é um dia");
                break;
        }
        Console.Beep();
        Console.ReadKey();
    }
}