using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {

            Car carro = new Car();

            Console.Write("o quanto deseja acelerar? ");
            int speed = Convert.ToInt32(Console.ReadLine());
            carro.acelerar(speed);
            Console.WriteLine(carro.Speed);

            Console.ReadKey();
        }
    }
}