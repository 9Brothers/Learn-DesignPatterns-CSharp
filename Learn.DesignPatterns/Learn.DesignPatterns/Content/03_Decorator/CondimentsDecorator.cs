using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DesignPatterns.Content._03_Decorator
{
  public abstract class CondimentsDecorator : Beverage
  {
    public abstract override string GetDescription();
  }
}
