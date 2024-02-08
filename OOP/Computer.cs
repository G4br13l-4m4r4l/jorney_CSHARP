using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Computer
    {
        String marca;
        String tipo;
        bool ligado = false;

        public Computer(String marca, string tipo)
        {
            Console.WriteLine("Computador registrado!");
            this.marca = marca;
            this.tipo = tipo;
        }

        public void ligar()
        {
            if (this.ligado)
            {
                Console.WriteLine("Já está ligado!");
            }
            else
            {
                ligado = true;
                Console.WriteLine("\n-------------------------\n\tComputer_on\n-------------------------\n");
            }
        }
    }
}
