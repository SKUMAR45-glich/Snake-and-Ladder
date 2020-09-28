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
            int curr_pos = 0;
            Random random = new Random();
            int play = 1;
            int sum = 0;
            while(play ==1)
            {
                int die = Random(1, 7);
                int option = Random(1, 4);
                switch(option)
                {
                    case no_play:
                         Console.WriteLine("No Play");
                         break;
                    case ladder:
                         curr_pos = curr_pos + die;
                         Console.WriteLine("Current Position"+curr_pos);
                         if (curr_pos>100)
                         {
                              curr_pos = 100;
                         }
                         sum++;
                         break;
                    case snake:
                         curr_pos = curr_pos - die;
                         Console.WriteLine("Current Position"+curr_pos);
                         if (curr_pos<0)
                         {
                              curr_pos = 0;
                         }
                         sum++;
                         break;
                    default:
                       Console.WriteLine("Roll the die");
                       break;
                }
                if (curr_pos == 0 || curr_pos == 100)
                {
                      play = 0;
                }
            }
            Console.WriteLine("Total moves:" + sum);    
        }
    }
}
