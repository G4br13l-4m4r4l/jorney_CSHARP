using System;

namespace RPSC;

class Program
{
    static void Main(string[] args)
    {
        Random rdm = new Random();//instanciando
        bool playAgain = true;

        String player;
        String computer;

        while(playAgain)
        {
            player = "";
            computer = "";
            while(player != "PEDRA" && player !="PAPEL" && player != "TESOURA")
            {
                Console.Write("Digite PEDRA, PAPEL, TESOURA: ");
                player = Console.ReadLine();
                player = player.ToUpper();

            }

            switch (rdm.Next(1, 4))
            {
                case 1:
                    computer = "PEDRA";
                    break;
                case 2:
                    computer = "PAPEL";
                    break;
                case 3:
                    computer = "TESOURA";
                    break;
            }
            Console.WriteLine("\nJogador: " + player);
            Console.WriteLine("Computador: " + computer);
            Console.Beep();

            switch(player)
            {
                case "PEDRA":
                    if (computer == "PEDRA") {
                        Console.WriteLine("É um empate! \n");
                    }else if(computer == "PAPEL")
                    {
                        Console.WriteLine("YOU LOSE! \n");
                    }
                    else
                    {
                        Console.WriteLine("YOU WIN! \n");
                    }
                    break;
                case "PAPEL":
                    if(computer == "PEDRA")
                    {
                        Console.WriteLine("YOU WIN! \n");
                    }else if(computer == "PAPEL")
                    {
                        Console.WriteLine("É um empate! \n");
                    }
                    else
                    {
                        Console.WriteLine("YOU LOSE! \n");
                    }
                    break;
                case "TESOURA":
                    if(computer == "PAPEL")
                    {
                        Console.WriteLine("YOU WIN! \n");
                    }else if(computer == "PEDRA")
                    {
                        Console.WriteLine("YOU LOSE! \n");
                    }
                    else
                    {
                        Console.WriteLine("É um empate! \n");
                    }
                    break;
            }
            Console.WriteLine("Deseja jogar novamente? (s/n)");
            String resp = Console.ReadLine();
            if (resp != "s")
            {
                playAgain = false;
                Console.WriteLine("__EXITING__");
            }
        }

        Console.ReadKey();
    }
}