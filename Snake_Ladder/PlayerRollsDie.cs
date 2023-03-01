using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    public class PlayerRollsDie
    {
        public static void PlayerRolls_Die()
        {
            // define snakes and ladders
             int[] snakes = { 17, 54, 62, 98 };
             int[] ladders = { 3, 24, 42, 72 };
             int[] snakeEnds = { 7, 34, 19, 79 };
             int[] ladderEnds = { 38, 33, 93, 84 };

            // function to roll the die
            static int RollDie()
            {
                Random random = new Random();
                return random.Next(1, 7);
            }

            // function to check if the current position has a snake or a ladder
            int CheckSnakeLadder(int pos)
            {
                for (int i = 0; i < snakes.Length; i++)
                {
                    if (pos == snakes[i])
                    {
                        return snakeEnds[i];
                    }
                }
                for (int i = 0; i < ladders.Length; i++)
                {
                    if (pos == ladders[i])
                    {
                        return ladderEnds[i];
                    }
                }
                return pos;
            }

            // main function to simulate the game
             void PlayGame()
            {
                int position = 0;
                while (position < 100)
                {
                    int roll = RollDie();
                    Console.WriteLine("You rolled a " + roll);
                    position += roll;
                    if (position > 100)
                    {
                        position -= roll;
                        Console.WriteLine("Oops! You need to roll exactly " + (100 - position) + " to reach 100. Try again.");
                    }
                    else
                    {

                        position = CheckSnakeLadder(position);
                        Console.WriteLine("Your current position is " + position);
                    }
                }
                Console.WriteLine("Congratulations! You won the game.");
            }

        
            {
                PlayGame();
            }
        }
    }
}
