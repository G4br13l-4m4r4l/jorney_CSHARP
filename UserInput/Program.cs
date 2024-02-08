using System;
namespace UserInput;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("what's your username? ");
        String name = Console.ReadLine();
        Console.Write("what's your age? ");
        int age_1 = Convert.ToInt32(Console.ReadLine());
        age_1 *= 2;
        age_1++;
        age_1 /= 3;
        Console.WriteLine("Welcome_@" + name);
        Console.WriteLine("your ID is:  " + age_1);
        Console.WriteLine(age_1.GetType());
        Console.Beep();
        Console.ReadKey();
    }
}