using System;

namespace SnakeLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");

            int player1Score, player2Score;

            player1Score = 0;
            player2Score = 0;
            Console.WriteLine("Initial Player Score : " + player1Score);

            DiceRolledToWin(ref player1Score, ref player2Score);
            if (player1Score > player2Score)
                Console.WriteLine("1st Player Won the Match");
            else
                Console.WriteLine("2nd Player Won the Match");
            

           

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

        static void DiceRolledToWin(ref int player1Score, ref int player2Score)
        {
            bool isLadder;
            while (player1Score != 100 && player2Score != 100)
            {
                isLadder = true;
                while (isLadder)
                    isLadder = RollAndPlay(ref player1Score);
                isLadder = true;
                while (isLadder)
                    isLadder = RollAndPlay(ref player2Score);

                Console.WriteLine("Current Score of 1st Player is " + player1Score);
                Console.WriteLine("Current Score of 2nd Player is " + player2Score);
            }

            return;
        }

        static bool RollAndPlay(ref int score)
        {
            int currentScore;
            currentScore = RollTheDie();

            string option;
            option = CheckOptions();

            switch (option)
            {
                case "NoPlay":
                    break;
                case "Ladder":
                    score += currentScore;
                    if (score > 100)
                        score -= currentScore;
                    break;
                case "Snake":
                    score -= currentScore;
                    break;
                default:
                    break;
            }

            if (score < 0)
                score = 0;

            if (option == "Ladder")
                return true;
            else
                return false;
        }
    }
}
