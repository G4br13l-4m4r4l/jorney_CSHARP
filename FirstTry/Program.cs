using System;
namespace FirstTry {
    class Program { 
        static void Main(string[] args)
        {
            
            //will make a beep in the console when it's open
            Console.Beep();

            int x = 10;
            int y = 2;
            const char symbol = '@';
            const string name = "leirbag";

            int z = x * y;

            Console.WriteLine("Hello_" + name);
            Console.WriteLine("Username: " + symbol + name);
            Console.WriteLine("RESULT: "+z);
            Console.ReadKey();
        }
    }
}
