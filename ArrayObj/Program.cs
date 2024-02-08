using System;
using System.Net.Http.Headers;

namespace ArrayObj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            Console.WriteLine("Quantos aviões são?");
            int quant = Convert.ToInt32(Console.ReadLine());
            aviao[] vrum = new aviao[quant];
            for (int i = 0; i < quant; i++)
            {
                Console.Write("Digite o modelo: ");
                vrum[i] = new aviao(Console.ReadLine());
            }
            foreach(aviao vv in vrum)
            {
                Console.WriteLine($"==> modelo armazenado: {vv.show()}");
            }
            Console.ReadKey();
        }
    }

    class aviao
    {
        String modelo;

        public aviao(String modelo)
        {
            this.modelo = modelo;
            Console.WriteLine("Avião criado!");
        }

        public String show()
        {
            return modelo;
        }

    }
}