using System;

namespace Learn.DesignPatterns._01_Strategy
{
  class Squeak : IQuackBehavior
  {
    public void quack()
    {
      Console.WriteLine("Squeak");
    }
  }
}
