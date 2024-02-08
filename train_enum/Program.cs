using System;

namespace train_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" _______  _______  __   __  _______  _______  __    _  _______  __    _  _______  _______  _______\r\n|       ||       ||  |_|  ||       ||       ||  |  | ||       ||  |  | ||       ||       ||       |\r\n|       ||   _   ||       ||    _  ||   _   ||   |_| ||    ___||   |_| ||_     _||    ___||  _____|\r\n|       ||  | |  ||       ||   |_| ||  | |  ||       ||   |___ |       |  |   |  |   |___ | |_____\r\n|      _||  |_|  ||       ||    ___||  |_|  ||  _    ||    ___||  _    |  |   |  |    ___||_____  |\r\n|     |_ |       || ||_|| ||   |    |       || | |   ||   |___ | | |   |  |   |  |   |___  _____| |\r\n|_______||_______||_|   |_||___|    |_______||_|  |__||_______||_|  |__|  |___|  |_______||_______|\n\n");
            Console.WriteLine($"{Components.placa_mae} is #{(int)Components.placa_mae}");
            Console.WriteLine($"{Components.processador} is #{(int)Components.processador}");
            Console.WriteLine($"{Components.placa_video} is #{(int)Components.placa_video}");
            Console.ReadKey();
        }

        enum Components
        {
            placa_mae = 1,
            processador = 2,
            RAM = 3,
            placa_video = 4,
            gabinete = 5,
            fonte = 6
        }
    }
}