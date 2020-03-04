using RPS.Models;
using System;

namespace RPS
{
  public class Program
  {
    public static void Main()
    {
      PlayGame();
    }

    public static void PlayGame()
    {
      Console.Clear();
      Console.WriteLine("Let's play rock, paper, scissors! \n Player 1, enter your choice:");
      string playerOneChoice = Console.ReadLine();
      Console.WriteLine("Player 2, what is your choice?");
      string playerTwoChoice = Console.ReadLine();
      try
      {
        string result = Game.CheckWin(playerOneChoice, playerTwoChoice);
        if (result == "Player 1" || result == "Player 2")
        {
          Console.WriteLine(result + " wins!!!");
        }
        else if (result == "It's a draw!")
        {
          Console.WriteLine(result);
        }
      }
      catch
      {
        Console.WriteLine("Woops, looks like there was an error. Please select rock, paper, or scissors next time. \n");
        PlayGame();
      }
    }
  }
}