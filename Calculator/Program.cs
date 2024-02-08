using System;

namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        bool sair = false;
        
        Console.WriteLine("Welcome_to_the_Calculator!");
        while (!sair) {
            int resp = 0;

            while (resp != 1 && resp != 2 && resp != 3 && resp != 4) { 
                Console.Write("Digite o número correspondente ao tipo de operação que deseja (1-soma/2-subtração/3-divisão/4-multiplicação): ");
                resp = Convert.ToInt32(Console.ReadLine());

                switch (resp) {
                    case 1:
                        Console.Write("Digite o primeiro número: ");
                        int 
                        break;
                    case 2:
                
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("ERROR_ TRY_AGAIN_");
                        break;
                }
                Console.WriteLine("Deseja fazer outra operação? (s/n) ");
                String resp_2 = Console.ReadLine();
                if (resp_2 != "s")
                {
                    resp = 0;
                }
                else
                {
                    sair = true;
                    Console.WriteLine("__SAINDO__")
                }
            }
        }
        
        Console.Beep();
        Console.ReadLine();
    }
}