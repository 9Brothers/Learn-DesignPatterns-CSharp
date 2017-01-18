using System;

namespace Learn.DesignPatterns.Content._04_Factory
{
  class NYStyleCheesePizza : Pizza
  {
    PizzaIngredientFactory ingredientFactory;
    public NYStyleCheesePizza(PizzaIngredientFactory ingredientFactory)
    {
      Name = "NY Style Sauce and Cheese Pizza";
      Dough = ingredientFactory.CreateDough();

      this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
      throw new NotImplementedException();
    }
  }
}