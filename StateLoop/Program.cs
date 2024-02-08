using System;
namespace StateLoop;

class Program
{
    static void Main(string[] args)
    {
        String user = "";

        while (user == "") {
            Console.Write("Type your username: ");
            user = Console.ReadLine();

            switch(user)
            {
                case "leirbag":
                    Console.WriteLine(user.Insert(0,"@") +" sign up!");
                    break;
                case "h4n4r_w1nt3r":
                    Console.WriteLine(user.Insert(0, "@") + " sign up!");
                    break;
                default:
                    Console.WriteLine("User not found!\n");
                    break;
            }

        }
            for(int i = 0; i < user.Length; i++) {
                Console.WriteLine(user[i]);
            }
            
            Console.Beep();

            Console.ReadKey();
    }
}