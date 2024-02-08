using System;

namespace poly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================\n\tAnimal World\n===============================\n");

            Console.Write("Type the name of the hawk: ");
            Hawk hawk = new Hawk(Console.ReadLine());

            Console.Write("Type the name of the rabbit: ");
            Rabbit rabbit = new Rabbit(Console.ReadLine());

            hawk.Hunt();
            rabbit.RunAway();


            Console.ReadKey();
        }
    }

    interface Iprey
    {
        public void RunAway();
    }
    interface IPredator
    {
        public void Hunt();
    }

    class Hawk : IPredator
    {
        String name;

        public Hawk(String name)
        {
            this.name = name;
        }
        public void Hunt() { 
            Console.WriteLine($"{name} is hunting!");
        }
    }

    class Rabbit : Iprey
    {
        String name;

        public Rabbit(String name)
        {
            this.name = name;
        }

        public void RunAway()
        {
            Console.WriteLine($"{name} is running for his life!");
        }
    }
}