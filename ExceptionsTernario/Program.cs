using System;

namespace ExceptionsTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------\n\tHello_there!\n------------------------------\n");
            bool continuar = true;
            
               while (continuar) {

                try
                {
                    Console.WriteLine("Digite a opção que deseja:\n(1-Mostrar mensagem/2-calcular algo/3-Sair)");
                    int resp = Convert.ToInt32(Console.ReadLine());

                    switch (resp)
                    {
                        case 1:
                            ShowText();
                            break;
                        case 2:
                            Console.Write("Digite um número: ");
                            double x = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite outro número: ");
                            double y = Convert.ToDouble(Console.ReadLine());
                            
                            Console.WriteLine("Resultado: " + Calc(x, y));
                            break;
                        case 3:
                            Console.WriteLine("___EXITING___");
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Comando não identificado!");
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Digite algum valor válido!\n");
                }
                catch (Exception e) {
                    Console.WriteLine(e.ToString());
                    Console.WriteLine("Something went wrong :(\n");
                }
            }



            Console.Beep();
            Console.ReadLine();
        }

        static void ShowText()
        {
            Console.Write("Message 1 or 2? ");
            int resposta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((resposta == 1)? "\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_\n\n\tH3LL8_TH3R3@\n\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_\n": "\n==============================\n\n\tH3LL8_W@RLD!\n\n==============================\n");
        }
        static Double Calc(Double x, Double y)
        {
            try
            {
                Console.WriteLine("\nQue tipo de calculo deseja realizar?\n(1-soma/2-subtrair/3-multiplicar/4-dividir)");
                int resp = Convert.ToInt32(Console.ReadLine());
                switch (resp)
                {
                    case 1:
                        return x + y;
                    case 2:
                        return x - y;
                    case 3:
                        return x * y;
                    case 4:
                        try
                        {
                            double result = x / y;
                            return result;
                        }catch(DivideByZeroException ex)
                        {
                            Console.WriteLine("Não pode ser divido por 0!");
                            return 0;
                        }
                    default:
                        Console.WriteLine("Comando não identificado!");
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Digite um valor válido!\n");
            }
            catch (ArithmeticException m) { 
                Console.WriteLine("Erro: " + m.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
            }

            return x;
        }
    }
}