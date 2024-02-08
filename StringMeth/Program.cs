using System;
namespace StringMeth;

class Program
{
    static void Main(string[] args)
    {
        String fullname = "Honor Winter";
        fullname = fullname.Replace(" ", "_").Replace("e", "3").Replace("o", "4").Replace("i", "1").ToLower().Insert(0,"@");

        Console.WriteLine("username: "+fullname);

        Console.Beep();
        Console.ReadKey();
    }
}