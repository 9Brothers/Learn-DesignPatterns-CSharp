using System;

namespace Learn.DesignPatterns.Content._04_Factory
{
  class ClamPizza : Pizza
  {
    PizzaIngredientFactory ingredientFactory;

    public ClamPizza(PizzaIngredientFactory ingredientFactory)
    {
      this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
      Console.WriteLine("Preparing " + Name);
      Cheese = ingredientFactory.CreateCheese();
      Clam = ingredientFactory.CreateClam();
    }
  }
}