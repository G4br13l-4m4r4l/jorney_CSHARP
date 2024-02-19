using System;
using System.Threading;
namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread maint = Thread.CurrentThread;
            maint.Name = "the main thread";

            Thread first = new Thread(CountUp);
            Thread second = new Thread(Countdown);

            first.Start();
            second.Start();

            Console.Write($"{maint.Name} finished!");
            Console.ReadKey();
        }

        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"the thread #1: {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("The tread #1 has finished!");
        }

        public static void Countdown()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"the thread #2: {i}");
                Thread.Sleep(800);
            }
            Console.WriteLine("The tread #2 has finished!");
        }
    }
}