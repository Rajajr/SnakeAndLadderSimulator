using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderSimulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC-2 Player rolls the die to get a number between 1 to 6
            Console.WriteLine("Welcome to Snake And Ladder Game");
            Console.WriteLine("Player");
            //variables
            var Player =0;
            var Die = 0;
            //randomcheck 
            Random random = new Random();
            //range from 1 to 6
            Die=random.Next(1,7);
            Console.WriteLine("Roll the die");
            Console.WriteLine("Number:{0}",Die);
            Console.ReadLine();
        }
    }
}
