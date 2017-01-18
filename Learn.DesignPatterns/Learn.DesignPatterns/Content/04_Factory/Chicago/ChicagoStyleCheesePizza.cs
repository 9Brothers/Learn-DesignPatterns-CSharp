using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DesignPatterns.Content._04_Factory.Chicago
{
  class ChicagoStyleCheesePizza : Pizza
  {
    public ChicagoStyleCheesePizza(PizzaIngredientFactory ingredientFactory)
    {
      Name = "Chicago Style Deep Dish Cheese Pizza";
      Dough = ingredientFactory.CreateDough();
      Sauce = ingredientFactory.CreateSauce();
    }

    public override void Cut()
    {
      Console.WriteLine("Cutting the pizza into square slices");
    }

    public override void Prepare()
    {
      throw new NotImplementedException();
    }
  }
}
