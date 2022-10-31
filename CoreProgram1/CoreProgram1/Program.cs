using System;

namespace CoreProgram1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CoreProgram Exercise 1");
            Console.WriteLine("1.FlipCoin" + "\n");
            Console.WriteLine("Enter option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.play(100);
                    break;
            }
        }
    }
}
