using System;

namespace QueenAttack.Models;
{
  class Queen
  {
    public static bool canAttack(int xQueen, int uQueen, int xComp, int yComp)
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
  }
}