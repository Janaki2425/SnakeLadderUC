using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class PlayerPosition
    {
        public const int NoPlay = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        public static void CheckingPlayerPosition()
        {

            Random random = new Random();
            int DiceRoll = random.Next(1, 7);

            Console.WriteLine("You are getting the Number:" + DiceRoll);

            Random random1 = new Random();
            int Check = random1.Next(0, 3);

            Console.WriteLine("Checking The status:" + Check);
            if (Check == NoPlay)
            {
                Console.WriteLine("The player stays in the same Position");
            }
            else if (Check == Ladder)
            {
                Console.WriteLine("You are moving Forward By: " + DiceRoll);
            }
            else if (Check == Snake)
            {
                Console.WriteLine("You are moving Backward by:" + DiceRoll);
            }

        }
    }
}