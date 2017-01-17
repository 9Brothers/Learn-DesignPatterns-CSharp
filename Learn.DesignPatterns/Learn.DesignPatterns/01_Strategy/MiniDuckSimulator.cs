using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DesignPatterns._01_Strategy
{
  abstract class MiniDuckSimulator
  {
    public static void Run()
    {
      Duck mallard = new MallardDuck();
      mallard.PerformQuack();
      mallard.PerformFly();

      Duck model = new ModelDuck();
      model.PerformFly();
      model.flyBehavior = new FlyRockedPowered();
      model.PerformFly();
    }
  }
}
