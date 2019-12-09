using System;
using System.Collections.Generic;

public class Queen
{
  public static bool canAttack(int xQueen, int yQueen, int xComp, int yComp)
  {
    // Horizontal or vertical match
    if(xQueen == xComp || yQueen == yComp)
    {
      return true;
    }
    // Diagonal match
    else if (Math.Abs(xQueen - xComp) == Math.Abs(yQueen - yComp))
    {
      return true;
    }
    else
    {
      return false;
    }
  }
  static void Main()
  {
    Dictionary<string, int> xCoordinates = new Dictionary<string, int>() { {"A", 1}, {"B", 2}, {"C", 3}, {"D", 4}, {"E", 5}, {"F", 6}, {"G", 7}, {"H", 8} };
  
    Console.WriteLine("Enter the Queen's horizontal coordinate  (A - H)");
    string input = Console.ReadLine().ToUpper(); // alphabetical
    int queenXInput = xCoordinates[input]; // get the number
  
    Console.WriteLine("Enter the Queen's vertical coordinate (1 - 8)");
    int queenYInput = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the computer's horizontal coordinate (A - H)");
    input = Console.ReadLine().ToUpper();
    int compXInput = xCoordinates[input];

    Console.WriteLine("Enter the computer's vertical coordinate (1 - 8)");
    int compYInput = int.Parse(Console.ReadLine());

    // Call canAttack method
    bool result = Queen.canAttack(queenXInput, queenYInput, compXInput, compYInput);

    if(result)
    {
      Console.WriteLine("The Queen attacked!");
    }
    else
    {
      Console.WriteLine("The Queen didn't attack.");
    }
  }
}