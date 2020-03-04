using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;

namespace RPS.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void CheckWin_PaperBeatsRock_Player1()
    {
      string result = Game.CheckWin("Paper", "Rock");
      Assert.AreEqual("Player 1", result);
    }

    [TestMethod]
    public void CheckWin_PaperBeatsRock_Player2()
    {
      string result = Game.CheckWin("Rock", "Paper");
      Assert.AreEqual("Player 2", result);
    }

    [TestMethod]
    public void CheckWin_RockBeatsScissors_Player1()
    {
      string result = Game.CheckWin("rock", "scissors");
      Assert.AreEqual("Player 1", result);
    }

    [TestMethod]
    public void CheckWin_RockBeatsScissors_Player2()
    {
      string result = Game.CheckWin("scissors", "rock");
      Assert.AreEqual("Player 2", result);
    }

    [TestMethod]
    public void CheckWin_ScissorsBeatsPaper_Player1()
    {
      string result = Game.CheckWin("scissors", "paper");
      Assert.AreEqual("Player 1", result);
    }

    [TestMethod]
    public void CheckWin_ScissorsBeatsPaper_Player2()
    {
      string result = Game.CheckWin("paper", "scissors");
      Assert.AreEqual("Player 2", result);
    }

    [TestMethod]
    public void CheckWin_PapersDraw_Draw()
    {
      string result = Game.CheckWin("paper", "paper");
      Assert.AreEqual("It's a draw!", result);
    }

    [TestMethod]
    public void CheckWin_RocksDraw_Draw()
    {
      string result = Game.CheckWin("rock", "rock");
      Assert.AreEqual("It's a draw!", result);
    }

    [TestMethod]
    public void CheckWin_ScissorsDraw_Draw()
    {
      string result = Game.CheckWin("scissors", "scissors");
      Assert.AreEqual("It's a draw!", result);
    }
  }
}