using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DesignPatterns.Content._04_Factory.Chicago
{
  class ChicagoPizzaStore : PizzaStore
  {
    public override Pizza CreatePizza(string type)
    {
      //if (type.Equals("cheese")) return new ChicagoStyleCheezePizza();
      //else if (type.Equals("pepperoni")) return new ChicagoStylePepperoniPizza();
      //else if (type.Equals("clam")) return new ChicagoStyleClamPizza();
      //else if (type.Equals("veggie")) return new ChicagoStyleVeggiePizza();
      //else return null;

      return null;
    }
  }
}
