using RPS.Models;
using System;

namespace RPS
{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();
      SelectGameType();
    }

    public static void SelectGameType()
    {
      Console.WriteLine("\n Let's play rock, paper, scissors! \n Select one-person (against the computer) or two-person game (against a friend): \n [ONE] or [TWO]");
      string version = Console.ReadLine();
      try
      {
        if (version.ToLower() == "one" || version == "1")
        {
          PlayOnePlayerGame();
        }
        else if (version.ToLower() == "two" || version == "2")
        {
          PlayTwoPlayerGame();
        }
      }
      catch
      {
        Console.WriteLine("Invalid input");
        SelectGameType();
      }
    }

    public static void PlayTwoPlayerGame()
    {
      Console.WriteLine("Player 1, enter your choice of rock, paper, or scissors:");
      string playerOneChoice = Console.ReadLine();
      Console.Clear();
      Console.WriteLine("Player 2, enter your choice of rock, paper, or scissors:");
      string playerTwoChoice = Console.ReadLine();
      try
      {
        string result = Game.CheckWin(playerOneChoice, playerTwoChoice);
        if (result == "Player 1" || result == "Player 2")
        {
          Console.WriteLine("\n Player 1 chose " + playerOneChoice + "\n Player 2 chose " + playerTwoChoice + "\n " + result + " wins!!! \n");
        }
        else if (result == "It's a draw!")
        {
          Console.WriteLine(result);
        }
      }
      catch
      {
        Console.WriteLine("Woops, looks like there was an error. Please select rock, paper, or scissors next time. \n");
        PlayTwoPlayerGame();
      }
    }

    public static void PlayOnePlayerGame()
    {
      Console.WriteLine("Enter your choice of rock, paper, or scissors:");
      string playerChoice = Console.ReadLine();
      string computerChoice = Game.GenerateComputerChoice();
      Console.WriteLine("The computer selected " + computerChoice);
      try
      {
        string result = Game.CheckWin(playerChoice, computerChoice);
        if (result == "Player 1")
        {
          Console.WriteLine("You win!");
        }
        else if (result == "Player 2")
        {
          Console.WriteLine("The computer wins!");
        }
        else if (result == "It's a draw!")
        {
          Console.WriteLine(result);
        }
      }
      catch
      {
        Console.WriteLine("Woops, looks like there was an error. Let's try that again.");
        PlayOnePlayerGame();
      }
    }
  }
}