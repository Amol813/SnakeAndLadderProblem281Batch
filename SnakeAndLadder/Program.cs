using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Snake And Ladder");

        PlayerRollsTheDie game = new PlayerRollsTheDie();
        PlayerRollsTheDie playerRollsTheDie = new PlayerRollsTheDie();

        int roll = playerRollsTheDie.RollDie();
        game.PlaySnakeAndLadder(roll);
    }
}