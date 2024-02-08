using System;

namespace Calc;

class Program
{
    static void Main(string[] args)
    {
        int n1;
        int n2;
        int result;
        bool sair = false;

        Console.WriteLine("Welcome_to_the_Calculator!");
        while (!sair)
        {
            int resp = 0;

            while (resp != 1 && resp != 2 && resp != 3 && resp != 4)
            {
                Console.WriteLine("Digite o número correspondente ao tipo de operação que deseja:");
                Console.WriteLine("(1-soma/2-subtração/3-divisão/4-multiplicação)");
                resp = Convert.ToInt32(Console.ReadLine());

                switch (resp)
                {
                    case 1:
                        Console.Write("Digite o primeiro número: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        n2 = Convert.ToInt32(Console.ReadLine());

                        result = n1 + n2;
                        Console.WriteLine("Resultado da soma: " + result + "\n");
                        break;
                    case 2:
                        Console.Write("Digite o primeiro número: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        n2 = Convert.ToInt32(Console.ReadLine());

                        result = n1 - n2;
                        Console.WriteLine("Resultado da subtração: " + result + "\n");
                        break;
                    case 3:
                        Console.Write("Digite o primeiro número: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        n2 = Convert.ToInt32(Console.ReadLine());

                        result = n1 / n2;
                        Console.WriteLine("Resultado da divisão: " + result + "\n");
                        break;
                    case 4:
                        Console.Write("Digite o primeiro número: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        n2 = Convert.ToInt32(Console.ReadLine());

                        result = n1 * n2;
                        Console.WriteLine("Resultado da multiplicação: " + result + "\n");
                        break;
                    default:
                        resp = 0;
                        Console.WriteLine("ERROR_ TRY_AGAIN_");
                        break;
                }
                Console.WriteLine("Deseja fazer outra operação? (s/n) ");
                String resp_2 = Console.ReadLine();
                if (resp_2 != "s")
                {
                    sair = true;
                    Console.WriteLine("__SAINDO__");
                }
                else
                {
                    resp = 0;
                }
            }
        }

        Console.Beep();
        Console.ReadLine();
    }
}