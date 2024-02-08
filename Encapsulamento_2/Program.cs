using System;

namespace Encapsulamento_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane();

            bool sair = true;

            while (sair)
            {
                Console.WriteLine("Type the speed of the plane: ");
                int speed = Convert.ToInt32(Console.ReadLine());
                plane.acelerar(speed);

                Console.Write("Wish to exit?(y/n) ");
                String resp = Console.ReadLine();

                if(resp == "y")
                {
                    Console.WriteLine("Exiting...");
                    sair = false;
                }

            }
        }
    }
}