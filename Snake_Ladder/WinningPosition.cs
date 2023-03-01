using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    public class WinningPosition
    {
        public static void Winning_Position()
        {
            // define snakes and ladders
             int[] snakes = { 17, 54, 62, 98 };
             int[] ladders = { 3, 24, 42, 72 };
             int[] snakeEnds = { 7, 34, 19, 79 };
             int[] ladderEnds = { 38, 33, 93, 84 };

            // function to roll the die
             int RollDie()
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

            // function to check for options (No Play, Ladder or Snake) and move the player accordingly
             int CheckOption(int pos)
            {
                Random random = new Random();
                int option = random.Next(0, 3);
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No Play. Your current position is " + pos);
                        break;
                    case 1:
                        int ladder = RollDie();
                        Console.WriteLine("You got a ladder! You move ahead by " + ladder + " positions.");
                        pos += ladder;
                        pos = CheckSnakeLadder(pos);
                        Console.WriteLine("Your current position is " + pos);
                        break;
                    case 2:
                        int snake = RollDie();
                        Console.WriteLine("Oh no! You got a snake! You move back by " + snake + " positions.");
                        pos -= snake;
                        if (pos < 0)
                        {
                            pos = 0;
                        }
                        pos = CheckSnakeLadder(pos);
                        Console.WriteLine("Your current position is " + pos);
                        break;
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
                        Console.WriteLine("Oops! You need to roll exactly " + (100 - (position - roll)) + " to reach 100. Try again.");
                    }
                    else
                    {
                        position = CheckOption(position);
                    }
                    if (position < 0)
                    {
                        position = 0;
                    }
                }
                Console.WriteLine("Congratulations! You won the game.");
            }

            // start the game
            
            {
                PlayGame();
            }
        }
    }
}
