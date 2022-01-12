using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class RepeatTill100
    {
        public const int NoPlay = 0;
        public const int Ladder = 1;
        public const int Snake = 2;
        public const int WinningPoint = 100;
        public static void Repeat()
        {

            int StartingPoint = 1;
            int CurrentPoint = 0;

            while (StartingPoint <= WinningPoint)
            {

                Random random = new Random();
                int DiceRoll = random.Next(1, 7);
                Console.WriteLine("You are getting the Number:" + DiceRoll);


                Random random1 = new Random();
                int Check = random1.Next(0, 3);

                CurrentPoint = StartingPoint + DiceRoll;
               
                if (CurrentPoint == 100)
                {

                    StartingPoint = StartingPoint - DiceRoll;
                    Console.WriteLine("You won the game");
                    break;
                }
                else if (CurrentPoint > 100)
                {

                    Console.WriteLine("you do not have any option and you will have to stay in that position: " + DiceRoll);
                    continue;



                }


                if (Check == NoPlay)
                {

                    Console.WriteLine("You do not have any option ");
                    Console.WriteLine("You are staying in that position");


                }
                else if (Check == Ladder)
                {
                    StartingPoint = StartingPoint + DiceRoll;
                    Console.WriteLine("You are moving forward by" + DiceRoll);
                }
                else if (Check == Snake)
                {
                    StartingPoint = StartingPoint - DiceRoll;
                    Console.WriteLine("You are moving Backward by" + DiceRoll);

                }

                if (StartingPoint <= 0)
                {


                    StartingPoint = StartingPoint - StartingPoint;
                    Console.WriteLine("You lost the Game:");
                    Console.WriteLine("Restart the Game");


                }

                
            }
        }
    }
}
