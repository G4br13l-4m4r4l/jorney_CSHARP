using System;

class Program { 
    static void Main(string[] args)
    {
        double a = 3.14;
        int b = Convert.ToInt32(a);

        Console.WriteLine(a.GetType());
        Console.WriteLine(b.GetType());

        Console.ReadLine();
    }
}