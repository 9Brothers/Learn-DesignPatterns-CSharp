using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DesignPatterns.Content._03_Decorator
{
  class HouseBlend : Beverage
  {
    public HouseBlend()
    {
      Description = "House Blend Coffee";
    }

    public override double Cost()
    {
      return .89;
    }
  }
}
