using System;

namespace Learn.DesignPatterns.Content._04_Factory
{
  class NYStyleVeggiePizza : Pizza
  {
    PizzaIngredientFactory ingredientFactory;

    public NYStyleVeggiePizza(PizzaIngredientFactory ingredientFactory)
    {
      this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
      Console.WriteLine("Preparing: " + Name);

      Veggies = ingredientFactory.CreateVeggies();
    }
  }
}