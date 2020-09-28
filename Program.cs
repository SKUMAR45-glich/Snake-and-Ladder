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
            Random random = new Random();
            int option = Random(1, 4);
            switch(option)
            {
                  case no_play:
                       Console.WriteLine("No Play");
                       break;
                  case ladder:
                       Console.WriteLine("moves ahead by the number of position received in the die");
                       break;
                  case snake:
                       Console.WriteLine("moves behind by the number of position received in the die");
                       break;
                  default:
                       Console.WriteLine("Roll the die");
                       break;
            }
        }
    }
}
