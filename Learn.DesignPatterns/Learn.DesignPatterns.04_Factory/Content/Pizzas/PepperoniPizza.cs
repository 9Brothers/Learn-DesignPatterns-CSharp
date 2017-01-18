using System;

namespace Learn.DesignPatterns.Content._04_Factory
{
  public class PepperoniPizza : Pizza
  {
    PizzaIngredientFactory ingredientFactory;

    public PepperoniPizza(PizzaIngredientFactory ingredientFactory)
    {
      this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
      Console.WriteLine("Preparing " + Name);
      Pepperoni = ingredientFactory.CreatePepperoni();      
    }
  }
}