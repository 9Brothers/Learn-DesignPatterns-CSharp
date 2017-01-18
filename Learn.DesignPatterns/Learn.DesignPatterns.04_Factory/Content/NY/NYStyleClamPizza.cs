using System;

namespace Learn.DesignPatterns.Content._04_Factory
{
  class NYStyleClamPizza : Pizza
  {
    PizzaIngredientFactory ingredientFactory;

    public NYStyleClamPizza(PizzaIngredientFactory ingredientFactory)
    {
      Name = "NY Style Clam Pizza";

      this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
      Console.WriteLine("Preparing: " + Name);

      Pepperoni = ingredientFactory.CreatePepperoni();
    }
  }
}