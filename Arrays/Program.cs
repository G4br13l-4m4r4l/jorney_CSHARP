using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------\n \tWelcome_back!\n----------------------------");
            String[] tech = new String[3];

            for(int i = 0; i < tech.Length; i++)
            {
                Console.Write("\nDigite uma marca: ");
                tech[i] = Console.ReadLine();
            }
            Console.Beep();
            Console.WriteLine("\n----------------------------\n \tDATA_STORED\n----------------------------\n");
            foreach (String t in tech) {
                Console.WriteLine("=> Data tech: _" + t + "_");
            }

            Console.ReadKey();
        }
    }
}
