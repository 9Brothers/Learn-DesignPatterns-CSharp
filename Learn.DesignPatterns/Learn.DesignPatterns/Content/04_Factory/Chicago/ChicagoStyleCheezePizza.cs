using System;

namespace Learn.DesignPatterns.Content._04_Factory.Chicago
{
  class ChicagoStyleCheezePizza : Pizza
  {
    public ChicagoStyleCheezePizza(PizzaIngredientFactory ingredientFactory)
    {
      Name = "Chicago Style Sauce and Cheese Pizza";
      Dough = ingredientFactory.CreateDough();
    }

    public override void Prepare()
    {
      throw new NotImplementedException();
    }
  }
}