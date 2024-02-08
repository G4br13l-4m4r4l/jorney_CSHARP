using System;

namespace MultiArr
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("===========================\n\tMulti_Array\n===========================");

            String[,] marcas = { {"Asus", "Dell", "Lenovo" }, {"Mancer", "Redragon", "Ryse"}, {"Logitech", "Kingston", "Nvídea"} };


            for (int i = 0; i < marcas.GetLength(0); i++)
            {
                for (int j = 0; j < marcas.GetLength(1); j++)
                {
                    Console.Write($"| => Data: {marcas[i,j]} | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n===========================\n\tEnd_Program\n===========================");

            Console.Beep();
            Console.ReadKey();
        }
    }
}