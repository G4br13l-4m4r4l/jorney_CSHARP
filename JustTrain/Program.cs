using System;

namespace JustTrain
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Beep();

            Console.WriteLine("==========================\n\tW3lc8m3\n==========================\n");

            Console.Write("Quantos deseja cadastrar? ");
            int quant = Convert.ToInt32(Console.ReadLine());
            Computer[] comp = new Computer[quant];

            for (int i = 0; i < quant; i++)
            {
                try
                {
                    Console.Write("Digite o modelo: ");
                    String model = Console.ReadLine();
                    Console.Write("Digite a quantidade de RAM: ");
                    int RAM = Convert.ToInt32(Console.ReadLine());

                    comp[i] = new Computer(model, RAM);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
            }

            foreach(Computer c in comp)
            {
                Console.WriteLine("\n==> Computer stored: \n");
                c.show();
            }
            Console.ReadKey();

        }
    }
}