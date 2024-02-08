using System;

namespace FlyPlane
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================\n\tWelcome_to_the_Airport\n======================================\n");
            Console.Write("Type your name please: ");
            String name = Console.ReadLine();
            Console.WriteLine($"Olá, {name}!");

            Console.Write($"Quantos aviões você tem {name}? ");
            int quant = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quant; i++)
            {
                String planeName = $"Plane_{i}";
                Console.Write("Digite o nome do piloto: ");
                String pilot = Console.ReadLine();
                Console.Write("Digite o nome do avião: ");
                String aviao = Console.ReadLine();

                Instanciar(pilot, aviao);
            }

            bool continuar = true;

            while( continuar )
            {
                Console.WriteLine("O que deseja fazer? (1-ligar aviao/2-voar/3-acelerar/4-pousar/5-sair)");
                try
                {
                    int actions = Convert.ToInt32(Console.ReadLine());
                    switch (actions)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:

                            break;
                        default:
                            Console.WriteLine("Command not found!");
                            break;
                    }
                }catch(FormatException f)
                {
                    Console.WriteLine("Something went wrong!");
                }
            }


            Console.Beep();
            Console.ReadKey();
        }

        public static Plane Instanciar(String name, String plane)
        {
            int Cont = 0;
            String Name = $"Plane_{Cont}";
            Plane aviao = new Plane(name, plane);
            return aviao;
        }
    }
}