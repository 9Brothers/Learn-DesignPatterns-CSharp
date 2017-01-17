﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DesignPatterns.Content._03_Decorator
{
  class Mocha : CondimentsDecorator
  {
    Beverage beverage;

    public Mocha(Beverage beverage)
    {
      this.beverage = beverage;      
    }

    public override string GetDescription()
    {
      return beverage.GetDescription() + ", Mocha";
    }

    public override double Cost()
    {
      return .20 + beverage.Cost();
    }
  }
}
