using System;

namespace Learn.DesignPatterns._01_Strategy
{
  class MuteQuack : IQuackBehavior
  {
    public void quack()
    {
      Console.WriteLine("<< Silence >>");
    }
  }
}
