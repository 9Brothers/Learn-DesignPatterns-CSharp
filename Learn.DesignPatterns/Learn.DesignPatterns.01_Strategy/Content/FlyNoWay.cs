using System;

namespace Learn.DesignPatterns._01_Strategy
{
  class FlyNoWay : IFlyBehavior
  {
    public void fly()
    {
      Console.WriteLine("I can't fly");
    }
  }
}
