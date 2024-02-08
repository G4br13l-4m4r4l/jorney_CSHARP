using System;
using System.Collections.Generic;
namespace ListParam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            List<Robot> list = new List<Robot>();

            list.Add(new Robot("Chad"));
            list.Add(new Robot("BRo"));
            list.Add(new Robot("C4d3"));

            foreach(Robot Oobot in list)
            {
                Console.WriteLine(Oobot);
            }            

            Console.ReadKey();
        }
    }

    class Robot
    {
        public String nome;
        
        public Robot(String nome)
        {
            this.nome = nome;
        }

        public override string ToString()
        {
            return $"His name is {nome}";
        }
    }
}