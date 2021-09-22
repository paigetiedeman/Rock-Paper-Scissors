using System.Collections.Generic;

namespace RockPaper
{
  public class Game
  {
    public string rockPaperGame(string player1, string player2)
    {
      if (player1 == "1")
      {
        if (player2 == "1")
        {
        return "draw";
        }
        else if (player2 == "2")
        {
        return "player 1 wins";
        }
        else
        {
        return "player 2 wins";
        }
      }
      else if (player1 == "2")
      {
        if (player2 == "1")
        {
          return "player 1 wins";
        }
        else if (player2 == "2")
        {
          return "draw";
        }
        else
        {
          return "player 2 wins";
        }
      }
      else
      {
        if (player2 == "1")
        {
          return "player 2 wins";
        }
        else if (player2 == "2")
        {
          return "player 1 wins";
        }
        else
        {
          return  "draw";
        }
      }
    }
  }
}