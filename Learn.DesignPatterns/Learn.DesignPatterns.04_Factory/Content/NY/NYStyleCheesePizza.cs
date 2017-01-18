using System;

namespace Learn.DesignPatterns.Content._04_Factory
{
  class NYStyleCheesePizza : Pizza
  {
    PizzaIngredientFactory ingredientFactory;

    public NYStyleCheesePizza(PizzaIngredientFactory ingredientFactory)
    {
      Name = "NY Style Sauce and Cheese Pizza";
      this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
      Console.WriteLine("Preparing: " + Name);

      Sauce = ingredientFactory.CreateSauce();
      Cheese = ingredientFactory.CreateCheese();
    }
  }
}