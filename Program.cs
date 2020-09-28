using System;

namespace start
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int no_on_die = random.Next(1,7);
            Console.WriteLine("Number on die is" + no_on_die);
        }
    }
}
