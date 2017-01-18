using System;

namespace Learn.DesignPatterns.Content._04_Factory.Chicago
{
  class ChicagoStyleVeggiePizza : Pizza
  {
    PizzaIngredientFactory ingredientFactory;

    public ChicagoStyleVeggiePizza(PizzaIngredientFactory ingredientFactory)
    {
      Name = "Chicago Style Veggie Pizza";

      this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
      Console.WriteLine("Preparing: " + Name);

      Veggies = ingredientFactory.CreateVeggies();
    }
  }
}