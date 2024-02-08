using System;

namespace ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------\n\tWelcome_back!\n---------------------------------\n");

            try
            {
                Console.Write("Quantos números serão calculados? ");
                int quant = Convert.ToInt32(Console.ReadLine());
                double[] valores = new double[quant];

                for (int i = 0; i < valores.Length; i++)
                {
                    Console.Write("Digite o número a ser calculado: ");
                    valores[i] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine(ShowResult(valores));
            }catch (FormatException e)
            {
                Console.WriteLine("Digite apenas números por gentileza");
            }
            Console.Write("\n____________END_PROGRAM____________");
            Console.Beep();
            Console.ReadKey();
        }

        static double ShowResult(params double[] result)
        {
            Console.WriteLine("\n--------------------------------\n\tCalculando\n--------------------------------\n");
            double resultTotal = 0;
            foreach (var item in result) {
                resultTotal += item;
            }
            resultTotal /= result.Length;
            return resultTotal;
        }
    }
}