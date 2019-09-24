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
    Dictionary<string, int> xCoordinates = new Dictionary<string, int>() { {"A", 1}, {"B", 2}, {"C", 3}, {"D", 4} };
  
    Console.WriteLine("Enter the Queen's horizontal coordinate  (A - D)");
    string input = Console.ReadLine(); // alphabetical
    int queenXInput = xCoordinates[input]; // get the number
  
    Console.WriteLine("Enter the Queen's vertical coordinate (1 - 4)");
    int queenYInput = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the computer's horizontal coordinate (A - D)");
    input = Console.ReadLine();
    int compXInput = xCoordinates[input];

    Console.WriteLine("Enter the computer's vertical coordinate (1 - 4)");
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