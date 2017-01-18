﻿using Learn.DesignPatterns.Content._04_Factory.NY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DesignPatterns.Content._04_Factory
{
  class NYPizzaStore : PizzaStore
  {
    public override Pizza CreatePizza(string type)
    {
      PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

      if (type.Equals("cheese")) return new NYStyleCheesePizza(ingredientFactory);
      else if (type.Equals("pepperoni")) return new NYStylePepperoniPizza();
      else if (type.Equals("clam")) return new NYStyleClamPizza();
      else if (type.Equals("veggie")) return new NYStyleVeggiePizza();
      else return null;
    }
  }
}
