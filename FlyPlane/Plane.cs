using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyPlane
{
    internal class Plane
    {
        String name;
        String piloto;
        bool ligado = false;
        bool voando = false;
        double speed = 0;
        static int quantidadeNoAr;

        public Plane(String name, String piloto)
        {
            this.name = name;
            this.piloto = piloto;
            quantidadeNoAr++;
        }

        public void Ligar()
        {
            if (ligado)
            {
                Console.WriteLine("Já estava ligado!");
            }
            else
            {
                ligado = true;
                Console.WriteLine("\n-------------------------------\n\tPlane_ON\n-------------------------------\n");
            }
        }
        public void Desligar()
        {
            if (!ligado)
            {
                Console.WriteLine("Já está desligado...");
            }else if(ligado && voando)
            {
                Console.WriteLine("Pouse primeiro!");
            }
            else
            {
                Console.WriteLine("Desligando...");
                Console.WriteLine("\n-------------------------------\n\tPlane_OFF\n-------------------------------\n");
                ligado= false;
            }
        }

        public void Voar()
        {
            if(ligado && !voando)
            {
                Console.WriteLine("levantando Vooo!!");
            }
        }

        public void Acelerar()
        {
            if (ligado && voando) {
                Console.WriteLine("Voando mais rápido vum vum!");
                speed += 100;
                Console.WriteLine($"=>Velocidade atual: {speed}KM/H");
            }
        }
    }
}
