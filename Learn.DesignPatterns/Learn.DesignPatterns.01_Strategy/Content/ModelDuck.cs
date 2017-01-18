using System;

namespace Learn.DesignPatterns._01_Strategy
{
  class ModelDuck : Duck
  {
    public ModelDuck()
    {
      base.flyBehavior = new FlyNoWay();
      base.quackBehavior = new Quack();
    }

    public override void display()
    {
      Console.WriteLine("I'm a model duck");
    }
  }
}
