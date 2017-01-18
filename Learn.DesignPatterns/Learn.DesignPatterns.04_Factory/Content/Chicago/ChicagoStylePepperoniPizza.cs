using System;

namespace Learn.DesignPatterns.Content._04_Factory.Chicago
{
  class ChicagoStylePepperoniPizza : Pizza
  {
    PizzaIngredientFactory ingredientFactory;

    public ChicagoStylePepperoniPizza(PizzaIngredientFactory ingredientFactory)
    {
      Name = "Chicago Style Pepperoni Pizza";

      this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
      Console.WriteLine("Preparing: " + Name);

      Pepperoni = ingredientFactory.CreatePepperoni();
    }
  }
}