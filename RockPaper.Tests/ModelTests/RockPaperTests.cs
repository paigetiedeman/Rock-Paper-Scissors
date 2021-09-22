using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using RockPaper;

namespace RockPaper.Tests
{
  [TestClass]
  public class RockPaperTests
  {
    [TestMethod]
    public void rockPaperGame_GameReturnsDraw_True()
    {
      Game testGame = new Game();
      string result = testGame.rockPaperGame("1", "1");
      Game testGame2 = new Game();
      string result2 = testGame2.rockPaperGame("2", "2");
      Game testGame3 = new Game();
      string result3 = testGame3.rockPaperGame("3", "3");
      Assert.AreEqual(result, "draw");
      Assert.AreEqual(result2, "draw");
      Assert.AreEqual(result3, "draw");
    }
    [TestMethod]
    public void rockPaperGame_GameReturnsPlayer1Wins_True()
    {
      Game testGame = new Game();
      string result = testGame.rockPaperGame("1", "2");
      Game testGame2 = new Game();
      string result2 = testGame2.rockPaperGame("2", "1");
      Game testGame3 = new Game();
      string result3 = testGame3.rockPaperGame("3", "2");
      Assert.AreEqual(result, "player 1 wins");
      Assert.AreEqual(result2, "player 1 wins");
      Assert.AreEqual(result3, "player 1 wins");
    }
    [TestMethod]
    public void rockPaperGame_GameReturnsPlayer2Wins_True()
    {
      Game testGame = new Game();
      string result = testGame.rockPaperGame("2", "3");
      Game testGame2 = new Game();
      string result2 = testGame2.rockPaperGame("3", "1");
      Game testGame3 = new Game();
      string result3 = testGame3.rockPaperGame("1", "3");
      Assert.AreEqual(result, "player 2 wins");
      Assert.AreEqual(result2, "player 2 wins");
      Assert.AreEqual(result3, "player 2 wins");
    }
  }
}


// rock = 1
// paper = 2
// scissors = 3
// Inputs
// player 1 input = var1
// player 2 input = var2
// // Rock v. Rock = "Draw"
// Rock v. Scissors = Rock wins
// Rock v. Paper = Paper wins
// Paper v. Scissors = Scissors wins
// Paper v. Paper = "Draw"
// Scissors v. Scissors = "Draw"


// return
// player 1 wins
// player 2 wins
// draw