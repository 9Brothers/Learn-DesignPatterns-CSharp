﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DesignPatterns.Content._03_Decorator
{
  public abstract class Beverage
  {
    protected string Description = "Unknown Beverage";

    public virtual string GetDescription()
    {
      return Description;
    }

    public abstract double Cost();
  }
}
