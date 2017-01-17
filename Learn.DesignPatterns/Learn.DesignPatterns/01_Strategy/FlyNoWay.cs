using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
