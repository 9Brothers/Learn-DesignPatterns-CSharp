using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DesignPatterns.Content._03_Decorator
{
  public class Expresso : Beverage
  {
    public Expresso()
    {
      Description = "Expresso";
    }

    public override double Cost()
    {
      return 1.99;
    }
  }
}
