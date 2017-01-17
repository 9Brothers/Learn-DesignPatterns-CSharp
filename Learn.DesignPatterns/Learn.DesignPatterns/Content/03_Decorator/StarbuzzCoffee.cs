using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DesignPatterns.Content._03_Decorator
{
  abstract class StarbuzzCoffee
  {
    public static void Run()
    {
      Beverage beverage = new Expresso();
      Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

      Beverage beverage2 = new HouseBlend();
      beverage2 = new Mocha(beverage2);
      Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());
    }
  }
}
