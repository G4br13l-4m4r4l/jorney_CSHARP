using System;
using System.Runtime.CompilerServices;

namespace StateWhile;

class Program
{
    static void Main(string[] args)
    {
        string username = "";

        while(username == "")
        {
            
            Console.Write("Type your user: ");
            username = Console.ReadLine();
            if (username == "") {
                Console.WriteLine("User not found!\n");
            }
        }
        Console.WriteLine("Hello_there " + username.Insert(0, "@"));

        Console.Beep();
        Console.ReadKey();
    }
}