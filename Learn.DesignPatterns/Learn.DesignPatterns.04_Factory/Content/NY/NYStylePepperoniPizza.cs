using System;

namespace Learn.DesignPatterns.Content._04_Factory
{
  class NYStylePepperoniPizza : Pizza
  {
    PizzaIngredientFactory ingredientFactory;

    public NYStylePepperoniPizza(PizzaIngredientFactory ingredientFactory)
    {
      Name = "NY Style Pepperoni Pizza";

      this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
      Console.WriteLine("Preparing: " + Name);

      Pepperoni = ingredientFactory.CreatePepperoni();
    }
  }
}