using System;

namespace Learn.DesignPatterns._01_Strategy
{
  class FlyWithWings : IFlyBehavior
  {
    public void fly()
    {
      Console.WriteLine("I'm flying!!");
    }
  }
}
