using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================\n\tST8R3D_G@RB@G3\n=================================\n");
            Console.Write("Type your Tagname: ");
            String tag = Console.ReadLine();
            Greetings(tag);
            
            Console.Write($"Wish to store something {tag}?(y/n) ");
            String resp = Console.ReadLine();

            Console.WriteLine((resp=="y")?"How many itens? ":"Too bad... See ya!\n");
            if(resp=="y")
            {
                try
                {
                    int quant = Convert.ToInt32(Console.ReadLine());
                    String[] store = new String[quant];
                    for(int i = 0; i < store.Length; i++)
                    {
                        try {
                            Console.Write("Type the data to store: ");
                            store[i] = Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                    Stores(store);
                }catch(ArithmeticException e)
                {
                    Console.WriteLine("Type only numbers please!");
                }
                finally
                {
                    Console.WriteLine("\nSee ya!");
                }
            }
            Console.Beep();
            Console.ReadKey();
        }
        static void Greetings(String name)
        {
            Console.WriteLine($"\nH3ll8_{name}!\n");
        }
        static void Stores(Array arr) {
            Console.WriteLine("\n--------------------------\n\tST8R3\n--------------------------\n");
            foreach(String s in arr) Console.WriteLine($"=> DATA_STORED: {s}");
        }
    }
}