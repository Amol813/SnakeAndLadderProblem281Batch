using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class PlayerStartPositionZero
    {
        private int playerPosition;
        private Random random;

        public PlayerStartPositionZero()
        {
            playerPosition = 0;
            random = new Random();
        }

        public void PlaySnakeAndLadder()
        {
            Console.WriteLine("Starting Snake and Ladder game...");
            Console.WriteLine("Your starting position is {0}.", playerPosition);
        }

    }
}

