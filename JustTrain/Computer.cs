using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustTrain
{
    internal class Computer
    {
        String modelo;
        int RAM;
        String video = null;


        public Computer(String modelo, int RAM)
        {
            this.modelo = modelo;
            this.RAM = RAM;
            Console.Write("tem placa de vídeo para a máquina? (s/n) ");
            String resp = Console.ReadLine();
            if (resp == "s") {
                Console.Write("Digite qual o modelo da placa: ");
                this.video = Console.ReadLine();
            }
            Console.WriteLine("\nMáquina cadastrada com sucesso!\n");
        }
        public void show()
        {
            Console.WriteLine($"\n_Modelo: {modelo}");
            Console.WriteLine($"_RAM: {RAM}");
            Console.WriteLine($"_placa_de_Video: {video}\n");
        }
    }
}
