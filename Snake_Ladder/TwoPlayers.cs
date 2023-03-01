using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    public class TwoPlayers
    {
        public static void Two_Players()
        {
            
            
                int position1 = 0;
                int position2 = 0;
                int currentPlayer = 1;
                bool playerWon = false;
                Random random = new Random();

                while (!playerWon)
                {
                    int diceRoll = random.Next(1, 7);
                    if (currentPlayer == 1)
                    {
                        Console.WriteLine("Player 1 rolled a {0}", diceRoll);
                        position1 += diceRoll;
                        if (position1 > 100)
                        {
                            position1 -= diceRoll;
                        }
                        if (position1 == 100)
                        {
                            playerWon = true;
                            break;
                        }
                        Console.WriteLine("Player 1's new position is {0}", position1);
                        if (position1 == 25 || position1 == 55 || position1 == 75)
                        {
                            position1 += random.Next(1, 7);
                            Console.WriteLine("Player 1 got a ladder and moves to {0}", position1);
                        }
                        else if (position1 == 10 || position1 == 20 || position1 == 50 || position1 == 80 || position1 == 90)
                        {
                            position1 -= random.Next(1, 7);
                            Console.WriteLine("Player 1 got a snake and moves to {0}", position1);
                        }
                        if (diceRoll != 6)
                        {
                            currentPlayer = 2;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Player 2 rolled a {0}", diceRoll);
                        position2 += diceRoll;
                        if (position2 > 100)
                        {
                            position2 -= diceRoll;
                        }
                        if (position2 == 100)
                        {
                            playerWon = true;
                            break;
                        }
                        Console.WriteLine("Player 2's new position is {0}", position2);
                        if (position2 == 25 || position2 == 55 || position2 == 75)
                        {
                            position2 += random.Next(1, 7);
                            Console.WriteLine("Player 2 got a ladder and moves to {0}", position2);
                        }
                        else if (position2 == 10 || position2 == 20 || position2 == 50 || position2 == 80 || position2 == 90)
                        {
                            position2 -= random.Next(1, 7);
                            Console.WriteLine("Player 2 got a snake and moves to {0}", position2);
                        }
                        if (diceRoll != 6)
                        {
                            currentPlayer = 1;
                        }
                    }
                }

                Console.WriteLine("Player {0} won the game!", currentPlayer);
            
        }
    }
}
