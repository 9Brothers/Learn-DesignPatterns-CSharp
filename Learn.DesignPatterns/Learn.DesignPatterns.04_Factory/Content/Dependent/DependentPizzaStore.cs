using Learn.DesignPatterns.Content._04_Factory.Chicago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DesignPatterns.Content._04_Factory.Dependent
{
  class DependentPizzaStore : PizzaStore
  {
    private string style;

    public DependentPizzaStore(string style)
    {
      this.style = style;
    }

    public override Pizza CreatePizza(string type)
    {
      Pizza pizza = null;

      if (style.Equals("NY")) pizza = new NYPizzaStore().CreatePizza(type);
      else if (style.Equals("Chicago")) pizza = new ChicagoPizzaStore().CreatePizza(type);
      else
      {
        Console.WriteLine("Error: Invalid type of pizza");
      }

      return pizza;
    }
  }
}
