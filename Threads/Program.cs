using System;
using System.Threading;
namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ______       ______       ______     ______       ___   __       ______       ______       ___   __       ______       ________      ______       ______\r\n/_____/\\     /_____/\\     /_____/\\   /_____/\\     /__/\\ /__/\\    /_____/\\     /_____/\\     /__/\\ /__/\\    /_____/\\     /_______/\\    /_____/\\     /_____/\\\r\n\\:::_ \\ \\    \\::::_\\/_    \\:::_ \\ \\  \\::::_\\/_    \\::\\_\\\\  \\ \\   \\:::_ \\ \\    \\::::_\\/_    \\::\\_\\\\  \\ \\   \\:::__\\/     \\__.::._\\/    \\::::_\\/_    \\::::_\\/_\r\n \\:\\ \\ \\ \\    \\:\\/___/\\    \\:(_) \\ \\  \\:\\/___/\\    \\:. `-\\  \\ \\   \\:\\ \\ \\ \\    \\:\\/___/\\    \\:. `-\\  \\ \\   \\:\\ \\  __      \\::\\ \\      \\:\\/___/\\    \\:\\/___/\\\r\n  \\:\\ \\ \\ \\    \\::___\\/_    \\: ___\\/   \\::___\\/_    \\:. _    \\ \\   \\:\\ \\ \\ \\    \\::___\\/_    \\:. _    \\ \\   \\:\\ \\/_/\\     _\\::\\ \\__    \\::___\\/_    \\_::._\\:\\\r\n   \\:\\/.:| |    \\:\\____/\\    \\ \\ \\      \\:\\____/\\    \\. \\`-\\  \\ \\   \\:\\/.:| |    \\:\\____/\\    \\. \\`-\\  \\ \\   \\:\\_\\ \\ \\   /__\\::\\__/\\    \\:\\____/\\     /____\\:\\\r\n    \\____/_/     \\_____\\/     \\_\\/       \\_____\\/     \\__\\/ \\__\\/    \\____/_/     \\_____\\/     \\__\\/ \\__\\/    \\_____\\/   \\________\\/     \\_____\\/     \\_____\\/\r\n\r\n");
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