using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                try
                {
                    Console.Write("O que deseja fazer agora? (1-ShowSomething/2-CalculateArea/3-pilotPlane/4-sair)");
                    int escolha = Convert.ToInt32(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            Console.WriteLine("\n __     __     ______     __         ______     ______     __    __     ______\r\n/\\ \\  _ \\ \\   /\\  ___\\   /\\ \\       /\\  ___\\   /\\  __ \\   /\\ \"-./  \\   /\\  ___\\\r\n\\ \\ \\/ \".\\ \\  \\ \\  __\\   \\ \\ \\____  \\ \\ \\____  \\ \\ \\/\\ \\  \\ \\ \\-./\\ \\  \\ \\  __\\\r\n \\ \\__/\".~\\_\\  \\ \\_____\\  \\ \\_____\\  \\ \\_____\\  \\ \\_____\\  \\ \\_\\ \\ \\_\\  \\ \\_____\\\r\n  \\/_/   \\/_/   \\/_____/   \\/_____/   \\/_____/   \\/_____/   \\/_/  \\/_/   \\/_____/\r\n\n");
                            break;
                        case 2:
                            Console.WriteLine("\n ______     ______     __         ______     __  __     __         ______     _____     ______     ______     ______\r\n/\\  ___\\   /\\  __ \\   /\\ \\       /\\  ___\\   /\\ \\/\\ \\   /\\ \\       /\\  __ \\   /\\  __-.  /\\  __ \\   /\\  == \\   /\\  __ \\\r\n\\ \\ \\____  \\ \\  __ \\  \\ \\ \\____  \\ \\ \\____  \\ \\ \\_\\ \\  \\ \\ \\____  \\ \\  __ \\  \\ \\ \\/\\ \\ \\ \\ \\/\\ \\  \\ \\  __<   \\ \\  __ \\\r\n \\ \\_____\\  \\ \\_\\ \\_\\  \\ \\_____\\  \\ \\_____\\  \\ \\_____\\  \\ \\_____\\  \\ \\_\\ \\_\\  \\ \\____-  \\ \\_____\\  \\ \\_\\ \\_\\  \\ \\_\\ \\_\\\r\n  \\/_____/   \\/_/\\/_/   \\/_____/   \\/_____/   \\/_____/   \\/_____/   \\/_/\\/_/   \\/____/   \\/_____/   \\/_/ /_/   \\/_/\\/_/\n");
                            Console.WriteLine("Digite qual operação deseja realizar: (1-SOMA/2-SUBTRAÇÃO/3-MULTIPLICAÇÃO/4-DIVISÃO/5-CANCELAR)");
                            try { 
                                int calc = Convert.ToInt32(Console.ReadLine());
                                switch(calc)
                                {
                                    case 1:
                                        Console.Write("são quantos números a serem somados? ");
                                        int quantidade_1 = Convert.ToInt32(Console.ReadLine());
                                        double[] numbers_1 = new double[quantidade_1];
                                        for (int i = 0;i < quantidade_1; i++)
                                        {
                                            Console.Write($"Digite o número {i + 1} a ser calculado: ");
                                            numbers_1[i] = Convert.ToDouble(Console.ReadLine());
                                        }
                                        Console.WriteLine($"\nResultado soma: {Soma(numbers_1)}");
                                        break;
                                    case 2:
                                        Console.Write("são quantos números a serem subtraidos? ");
                                        int quantidade_2 = Convert.ToInt32(Console.ReadLine());
                                        double[] numbers_2 = new double[quantidade_2];
                                        for (int i = 0; i < quantidade_2; i++)
                                        {
                                            Console.Write($"Digite o número {i + 1} a ser calculado: ");
                                            numbers_2[i] = Convert.ToDouble(Console.ReadLine());
                                        }
                                        Console.WriteLine($"\nResultado subtração: {Sub(numbers_2)}");
                                        break;
                                    case 3:
                                        break;
                                    case 4:
                                        Console.WriteLine("Atenção! só pode dividir dois números!\n");
                                        Console.Write("Digite o primeiro número para a divisão: ");
                                        double x = Convert.ToDouble(Console.ReadLine());
                                        Console.Write("Agora digite o número que irá dividir o primeiro: ");
                                        double y = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine($"\nResultado divisão: {Div(x,y)}");
                                        break;
                                    case 5:
                                        Console.WriteLine("Operação cancelada!");
                                        break;
                                    default:
                                        Console.WriteLine("Command not found!");
                                        break;
                                }
                            }catch(FormatException f2)
                            {
                                Console.WriteLine("Type only numbers please!\n OPERATION CANCELLED!");
                            }
                            break;
                        case 3:
                            break;
                        case 4:
                            Console.WriteLine("\n ______       __     __      ________      _________   ________      ___   __       _______\r\n/_____/\\     /__/\\ /__/\\    /_______/\\    /________/\\ /_______/\\    /__/\\ /__/\\    /______/\\\r\n\\::::_\\/_    \\ \\::\\\\:.\\ \\   \\__.::._\\/    \\__.::.__\\/ \\__.::._\\/    \\::\\_\\\\  \\ \\   \\::::__\\/__\r\n \\:\\/___/\\    \\_\\::_\\:_\\/      \\::\\ \\        \\::\\ \\      \\::\\ \\      \\:. `-\\  \\ \\   \\:\\ /____/\\\r\n  \\::___\\/_     _\\/__\\_\\_/\\    _\\::\\ \\__      \\::\\ \\     _\\::\\ \\__    \\:. _    \\ \\   \\:\\\\_  _\\/\r\n   \\:\\____/\\    \\ \\ \\ \\::\\ \\  /__\\::\\__/\\      \\::\\ \\   /__\\::\\__/\\    \\. \\`-\\  \\ \\   \\:\\_\\ \\ \\\r\n    \\_____\\/     \\_\\/  \\__\\/  \\________\\/       \\__\\/   \\________\\/     \\__\\/ \\__\\/    \\_____\\/\r\n\n");
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Command not found!");
                            break;
                    }
                }
                catch (FormatException fe) {
                    Console.WriteLine(fe.Message);
                    Console.WriteLine("Type only numbers please!");
                }
            }
            Console.ReadKey();
        }

        public static double Soma(params double[] x)
        {
            double result = 0;
            foreach (double i in x)
            {
                result += i;
            }
            return result;
        }
        public static double Sub(params double[] x)
        {
            double[] result = new double[x.Length];
            
            return 23;
        }

        public static double Mult(params double[] x)
        {
            double result = 1;
            foreach (double s in x)
            {
                result *= s;
            }
            return result;
        }

        public static double Div(double x, double y)
        {
            if (x % y == 0)
            {
                return x / y;
            }
            else
            {
                return 0;
            }

        }

    }
}