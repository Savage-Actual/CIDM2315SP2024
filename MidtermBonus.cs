using System;

public class ThePlayer
{
    private int points;

    public ThePlayer(int initial)
    {
        points = initial;
    }

    public int GetPoints()
    {
        return points;
    }

    public void WinRound()
    {
        points += 5;
    }

    public void LoseRound()
    {
        points -= 5;
    }

    public string playerDecision()
    {
        Console.WriteLine("Rock, Paper, Scissors, Start!");
        Console.WriteLine($"You have {points} points.");
        Console.WriteLine("Please input your choice: rock, paper, or scissors.");
        string decision = Console.ReadLine().Trim().ToLower();
        while (decision != "rock" && decision != "paper" && decision != "scissors")
        {
            Console.WriteLine("Invalid input. Please enter Rock, Paper, or Scissors: ");
            decision = Console.ReadLine().Trim().ToLower();
        }
        return decision;
    }
}

public class ComputerPlayer
{
    public string ComputerDecision()
    {
        Random rnd = new Random();
        int rnd_num = rnd.Next(0, 3);
        if (rnd_num == 0)
            return "rock";
        else if (rnd_num == 1)
            return "paper";
        else
            return "scissors";
    }
}

public class RockPaperScissors
{
    public static void Main(string[] args)
    {
        ThePlayer player = new ThePlayer(5);
        ComputerPlayer computer = new ComputerPlayer();

        while (true)
        {
            string playerDecision = player.playerDecision();
            string computerDecision = computer.ComputerDecision();

            Console.WriteLine($"Your Decision: {playerDecision}");
            Console.WriteLine($"Computer Decision: {computerDecision}");

            if (playerDecision == computerDecision)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((playerDecision == "rock" && computerDecision == "scissors") ||
                     (playerDecision == "paper" && computerDecision == "rock") ||
                     (playerDecision == "scissors" && computerDecision == "paper"))
            {
                Console.WriteLine("You Win!");
                player.WinRound();
            }
            else
            {
                Console.WriteLine("You Lose!");
                player.LoseRound();
            }

            Console.WriteLine($"You have {player.GetPoints()} points.");

            if (player.GetPoints() <= 0)
            {
                Console.WriteLine("Sorry, you don't have enough points. Thanks for playing.");
                break;
            }

            Console.WriteLine("Play again? Input y to continue, or n to exit");
            string playAgain = Console.ReadLine().Trim().ToLower();
            if (playAgain != "y")
                break;
        }

        Console.WriteLine("Thanks for playing");
    }
}