using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================\n\tWelcome_To_OOP\n==============================\n");

            Console.Write("Digite a marca do computador: ");
            String name = Console.ReadLine();
            Console.Write("Digite o tipo: ");
            String tipo = Console.ReadLine();

            Computer comp_1 = new Computer(name, tipo);

            comp_1.ligar();
        }
    }
}