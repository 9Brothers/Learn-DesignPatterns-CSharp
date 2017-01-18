using Learn.DesignPatterns.Content._04_Factory.Chicago;
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
      Pizza pizza = null;
      PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

      if (type.Equals("cheese")) pizza = new ChicagoStyleCheesePizza(ingredientFactory);
      else if (type.Equals("pepperoni")) pizza = new ChicagoStylePepperoniPizza(ingredientFactory);
      else if (type.Equals("clam")) pizza = new ChicagoStyleClamPizza(ingredientFactory);
      else if (type.Equals("veggie")) pizza = new ChicagoStyleVeggiePizza(ingredientFactory);

      return pizza;
    }
  }
}
