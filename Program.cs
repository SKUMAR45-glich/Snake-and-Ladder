using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace start
{
    class Program
    {
        static void Main(string[] args)
        {
            public const no_play = 1;
            public const ladder = 2;
            public const snake = 3;
            int curr_pos1 = 0;
            int curr_pos2 = 0;
            Random random = new Random();
            int player = 1;
            int player = 2;
            int sum = 0;
            while(player ==1)
            {
                int die = Random(1, 7);
                int option = Random(1, 4);
                switch(option)
                {
                    case no_play:
                         //Console.WriteLine("No Play");
                         player =2;
                         break;
                    case ladder:
                         curr_pos1 = curr_pos1 + die;
                         //Console.WriteLine("Current Position"+curr_pos);
                         if (curr_pos1>100)
                         {
                              curr_pos1 = 100;
                         }
    //sum++;
                         break;
                    case snake:
                         curr_pos1 = curr_pos1 - die;
                         //Console.WriteLine("Current Position"+curr_pos);
                         if (curr_pos1<0)
                         {
                              curr_pos1 = 0;
                         }
//sum++;                 
                         player=2;
                         break;
                   default:
                         Console.WriteLine("Roll the die");
                         break;
                }
            }
            while (player == 2)
            {
                      int die = Random(1, 7);
                      int option = Random(1, 4);
                      switch (option)
                      {
                             case no_play:
            //Console.WriteLine("No Play");
                             player = 2;
                             break;
                      case ladder:
                             curr_pos2 = curr_pos2 + die;
            //Console.WriteLine("Current Position"+curr_pos);
                             if (curr_pos2 > 100)
                             {
                                    curr_pos2 = 100;
                             }
            //sum++;
                             break;
                      case snake:
                             curr_pos2 = curr_pos2 - die;
            //Console.WriteLine("Current Position"+curr_pos);
                             if (curr_pos2 < 0)
                             {
                                   curr_pos2 = 0;
                             }
            //sum++;                 
                             player = 1;
                             break;
                      default:
                             Console.WriteLine("Roll the die");
                             break;
                }
                if (curr_pos1 == 100)
                {
                       Console.WriteLine("Winner is Player1");
                }
                else if(curr_pos2==100)
                {
                       Console.WriteLine("Winner is Player2");
                }
            }    
        }
    }
}