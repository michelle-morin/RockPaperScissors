using System;

namespace RPS.Models
{
  public class Game
  {
    public static string CheckWin(string playerOneChoice, string playerTwoChoice)
    {
      if ((playerOneChoice.ToLower() == "paper" && playerTwoChoice.ToLower() == "rock") || (playerOneChoice.ToLower() == "rock" && playerTwoChoice.ToLower() == "scissors") || (playerOneChoice.ToLower() == "scissors" && playerTwoChoice.ToLower() == "paper"))
      {
        return "Player 1";
      }
      else if ((playerOneChoice.ToLower() == "rock" && playerTwoChoice.ToLower() == "paper") || (playerOneChoice.ToLower() == "scissors" && playerTwoChoice.ToLower() == "rock") || (playerOneChoice.ToLower() == "paper" && playerTwoChoice.ToLower() == "scissors"))
      {
        return "Player 2";
      }
      else if (playerOneChoice.ToLower() == playerTwoChoice.ToLower())
      {
        return "It's a draw!";
      }
      else
      {
        throw new System.InvalidOperationException("Invalid input");
      }
    }

    public static string GenerateComputerChoice()
    {
      Random random = new Random();
      int randomNumber = random.Next(0, 3);
      if (randomNumber == 0)
      {
        return "rock";
      }
      else if (randomNumber == 1)
      {
        return "paper";
      }
      else if (randomNumber == 2)
      {
        return "scissors";
      }
      else
      {
        return "error";
      }
    }
  }
}