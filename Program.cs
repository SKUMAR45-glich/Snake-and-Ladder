using System;

namespace SnakeLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
            
            int playerScore;
            int diceRolled;

            playerScore = 0;
            Console.WriteLine("Initial Player Score : " + playerScore);

            diceRolled = DiceRolledToWin();
            Console.WriteLine("The player rolled the dice " + diceRolled + " number of times to win");

            return;
        }

        static int RollTheDie()
        {
            Random random = new Random();
            int score = random.Next(1, 7);
            return score;
        }

        static string CheckOptions()
        {
            string[] options = new string[3] { "NoPlay", "Ladder", "Snake" };
            int idx;

            Random random = new Random();
            idx = random.Next(0, 3);

            return options[idx];
        }

        static int DiceRolledToWin()
        {
            int playerScore = 0;
            int terms = 0;

            while (playerScore != 100)
            {
                if (playerScore < 0)
                    playerScore = 0;

                int currentScore;
                currentScore = RollTheDie();
                terms++;

                string option;
                option = CheckOptions();

                switch (option)
                {
                    case "NoPlay":
                        break;
                    case "Ladder":
                        playerScore += currentScore;
                        if (playerScore > 100)
                            playerScore -= currentScore;
                        break;
                    case "Snake":
                        playerScore -= currentScore;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Current Score is " + playerScore);
            }

            return terms;
        }
    }
}
