using System;

namespace Learn.DesignPatterns._01_Strategy
{
  class Quack : IQuackBehavior
  {
    public void quack()
    {
      Console.WriteLine("Quack");
    }
  }
}
