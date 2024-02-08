using System;

namespace Remebering
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("============================\n\tWelcome_back\n============================\n");

            Console.Write("Digite o seu nick: ");
            String nick = Console.ReadLine();

            Console.WriteLine($"\nWelcome {nick}!");

            Console.Write("Type the name of the dog: ");
            Dog dog = new Dog(Console.ReadLine());

            Console.Write("Type the name of the bird: ");
            Bird bird = new Bird(Console.ReadLine());

            Console.Write("Type the name of the hamster: ");
            Hamster ham = new Hamster(Console.ReadLine());


            Animal[] animals = {dog, bird, ham};
            
            foreach( Animal a in animals )
            {
                Console.WriteLine(a.ToString());
            }

            Console.Beep();
            Console.ReadKey();
        }
    }
}