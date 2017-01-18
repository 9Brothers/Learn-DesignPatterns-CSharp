using System;

namespace Learn.DesignPatterns.Content._04_Factory.Chicago
{
  class ChicagoStyleClamPizza : Pizza
  {
    PizzaIngredientFactory ingredientFactory;

    public ChicagoStyleClamPizza(PizzaIngredientFactory ingredientFactory)
    {
      Name = "Chicago Style Clam Pizza";

      this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
      Console.WriteLine("Preparing: " + Name);

      Clam = ingredientFactory.CreateClam();
    }
  }
}