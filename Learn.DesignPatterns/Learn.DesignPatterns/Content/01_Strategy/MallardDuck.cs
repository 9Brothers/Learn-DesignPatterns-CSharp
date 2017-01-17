using System;

namespace Learn.DesignPatterns._01_Strategy
{
  class MallardDuck : Duck
  {
    public MallardDuck()
    {
      base.quackBehavior = new Quack();
      base.flyBehavior = new FlyWithWings();
    }

    public override void display()
    {
      Console.WriteLine("I'm a real Mallard duck");
    }
  }
}
