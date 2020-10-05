using System;

namespace SnakeLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
            
            int playerScore;

            playerScore = 0;
            Console.WriteLine("Initial Player Score : " + playerScore);

            int currentScore;
            currentScore = RollTheDie();
            Console.WriteLine("The die rolled to " + currentScore);

            string option;
            option = CheckOptions();
            Console.WriteLine("We got the option " + option);

            switch (option)
            {
                case "NoPlay":
                    break;
                case "Ladder":
                    playerScore += currentScore;
                    break;
                case "Snake":
                    playerScore -= currentScore;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Score After rolling the dice is " + playerScore);

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
    }
}
