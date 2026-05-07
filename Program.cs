using System;

namespace rpc;

class Game
{
    int PlayerChoise = 0;
    bool NewGame = true;

    static void Main(string[] args)
    {
        int ComputerScore = 0;
        int PlayerScore = 0;
        while (true)
        {   
            string PlayAgain = null;
            int ComputerChoise = Random.Shared.Next(1, 4);
            int Input;
            while (true)
            {
                Console.WriteLine("Ваш выбор?");
                Console.WriteLine("1.Камень 2.Ножницы 3.Бумага");
                string firstinput = Console.ReadLine();
                if (int.TryParse(firstinput, out Input))
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            //int Input = int.Parse(Console.ReadLine());

            if (Input == ComputerChoise)
            {
                Console.WriteLine("Ничья");
            }
            else if (Input == 1 && ComputerChoise == 2 || Input == 2 && ComputerChoise == 3 || Input == 3 && ComputerChoise == 1)
            {
                Console.WriteLine("Победа");
                PlayerScore++;
                if (PlayerScore == 3)
                {
                    Console.WriteLine("Ты выйграл из 3.");
                    ComputerScore = 0;
                    PlayerScore = 0;
                    Console.WriteLine("Играем еще? [Д/Н]");
                    PlayAgain = Console.ReadLine();
                    
                    if (PlayAgain.ToUpper() == "Д" || PlayAgain.ToUpper() == "Y")
                    {

                    }
                    else
                    {
                        break;
                    }

                }
            }
            
            else
            {
                Console.WriteLine("Поражение");
                ComputerScore++;
                if (ComputerScore == 3)
                {
                    Console.WriteLine("Ты проиграл из 3.");
                    ComputerScore = 0;
                    PlayerScore = 0;
                    PlayAgain = Console.ReadLine();

                    if (PlayAgain.ToUpper() == "Д" || PlayAgain.ToUpper() == "Y")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            

        }
    }
}