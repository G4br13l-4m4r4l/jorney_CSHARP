using System;

namespace Meth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n\n\tW3lc0m3_B2ck!\n\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");

            Console.Write("Quantos dados serão armazenados?");
            int resp = Convert.ToInt32(Console.ReadLine());
            String[] names = new string[resp];

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Digite o nome para armazena-lo: ");
                names[i] = Console.ReadLine();
            }
            Console.Beep();

            Console.WriteLine("\n----------------------------\n\tData_Stored\n----------------------------\n");

            foreach(String name in names)
            {
                show(name);
            }

            Console.ReadKey();
        }

        static void show(String name)
        {
            Console.WriteLine("=> Data stored: " + name);
        }
    }
}