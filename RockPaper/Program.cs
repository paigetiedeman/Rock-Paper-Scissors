using System;
using System.Collections.Generic;
using RockPaper;

public class Program 
{
  public static void Main()
  {
    Console.WriteLine("Game of Rock, Paper, Scissors");
    Console.WriteLine("1.Rock");
    Console.WriteLine("2.Paper");
    Console.WriteLine("3.Scissors");
    string userInput = Console.ReadLine();
    Game testGame = new Game();
    string result = testGame.rockPaperGame(userInput);
    foreach (string input in result)
    {
      Console.WriteLine(input);
    }
    Main();
  }
}