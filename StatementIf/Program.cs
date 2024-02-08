using System;

namespace StatementIf;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("type your name: ");
        String name = Console.ReadLine();
        Console.Write("Type your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        name = name.Insert(0, "@").ToLower();
        Console.WriteLine(name);
        if(age > 18)
        {
            Console.WriteLine("you are a major!");
        }else if(age <17 && age > 12)
        {
            Console.WriteLine("you are a teenage mutant ninja turtle!");
        }
        else
        {
            Console.WriteLine("you are just a child!");
        }
        Console.Beep();
        Console.ReadKey();
    }
}