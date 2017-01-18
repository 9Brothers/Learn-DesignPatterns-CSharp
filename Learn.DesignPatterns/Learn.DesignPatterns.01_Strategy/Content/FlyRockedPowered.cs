using System;

namespace Learn.DesignPatterns._01_Strategy
{
  class FlyRockedPowered : IFlyBehavior
  {
    public void fly()
    {
      Console.WriteLine("I'm flying with a rocket!");
    }
  }
}
