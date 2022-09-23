using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeAndLadderSimulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC-4 Repeat till the Player Reaches the Winning Position 100
            Console.WriteLine("Welcome to Snake And Ladder Game");
            Console.WriteLine("Player1");
            //variables
            var Player1 =0;
            var Die = 0;
            var Option = 0;
            var Num=0;

            //constant
            const int Ladder = 1;
            const int Snake = 2;
            const int No_Play = 0;

            //randomcheck 
            Random random = new Random();
            while(Player1 < 100)
            {
                //range from 1 to 6
                Die = random.Next(1, 7);
                Console.WriteLine("Die Number:{0}", Die);
                Option = random.Next(0, 3);
                Console.WriteLine("Player1 Option: {0}", Option);

                switch (Option)
                {
                    case Ladder:
                        Player1=Player1 + Die;
                        Console.WriteLine("Ladder");
                        Console.WriteLine("Position : {0} ", Player1);
                        break;

                    case Snake:
                        Player1 = Player1 - Die;
                        if (Player1<0)
                        {
                            Player1=0;
                        }
                        Console.WriteLine("Snake");
                        Console.WriteLine("position: {0}", Player1);
                        break;
                    case No_Play:
                        Console.WriteLine("No Play");
                        Console.WriteLine("position: {0}", Player1);
                        break;
                }

                Num++;

            }
            Console.ReadLine();
        }
    }
}
