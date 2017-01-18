using System;

namespace Learn.DesignPatterns.Content._04_Factory
{
  public class VeggiePizza : Pizza
  {
    PizzaIngredientFactory ingredientFactory;

    public VeggiePizza(PizzaIngredientFactory ingredientFactory)
    {
      this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
      Console.WriteLine("Preparing " + Name);
      Veggies = ingredientFactory.CreateVeggies();
    }
  }
}