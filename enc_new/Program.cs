using System;

namespace enc_new
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(" ______     __           ________       ___   __       ______\r\n/_____/\\   /_/\\         /_______/\\     /__/\\ /__/\\    /_____/\\\r\n\\:::_ \\ \\  \\:\\ \\        \\::: _  \\ \\    \\::\\_\\\\  \\ \\   \\::::_\\/_\r\n \\:(_) \\ \\  \\:\\ \\        \\::(_)  \\ \\    \\:. `-\\  \\ \\   \\:\\/___/\\\r\n  \\: ___\\/   \\:\\ \\____    \\:: __  \\ \\    \\:. _    \\ \\   \\::___\\/_\r\n   \\ \\ \\      \\:\\/___/\\    \\:.\\ \\  \\ \\    \\. \\`-\\  \\ \\   \\:\\____/\\\r\n    \\_\\/       \\_____\\/     \\__\\/\\__\\/     \\__\\/ \\__\\/    \\_____\\/\r\n\n");
            Plane plane = new Plane();
            bool continuar = true;
            Console.WriteLine("You have are in a plane now!");
            while (continuar)
            {
                Console.Write("\n Do you want to go faster? (y/n) ");
                String resp = Console.ReadLine();
                if (resp == "y")
                {
                    Console.Write("\nHow much do you want to acellerate? ");
                    plane.acelerar(Convert.ToInt32(Console.ReadLine()));
                }
                else
                {
                    Console.WriteLine($"\n=> You are now going at {plane.Speed} KM/H");
                }
                Console.Write("\nWish to continue? (y/n) ");
                String resp_2 = Console.ReadLine();
                if(resp_2 != "y")
                {
                    continuar = false;
                    Console.WriteLine(" ______     __  __     __     ______   __     __   __     ______\r\n/\\  ___\\   /\\_\\_\\_\\   /\\ \\   /\\__  _\\ /\\ \\   /\\ \"-.\\ \\   /\\  ___\\\r\n\\ \\  __\\   \\/_/\\_\\/_  \\ \\ \\  \\/_/\\ \\/ \\ \\ \\  \\ \\ \\-.  \\  \\ \\ \\__ \\\r\n \\ \\_____\\   /\\_\\/\\_\\  \\ \\_\\    \\ \\_\\  \\ \\_\\  \\ \\_\\\\\"\\_\\  \\ \\_____\\\r\n  \\/_____/   \\/_/\\/_/   \\/_/     \\/_/   \\/_/   \\/_/ \\/_/   \\/_____/\r\n");
                }
            }
            Console.Beep();
            Console.ReadKey();
        }
    }
}