using System;

namespace Learn.DesignPatterns.Content._04_Factory
{
  class CheesePizza : Pizza
  {
    PizzaIngredientFactory ingredientFactory;

    public CheesePizza(PizzaIngredientFactory ingredientFactory)
    {
      this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
      Console.WriteLine("Preparing: " + Name);

      Dough = ingredientFactory.CreateDough();
      Sauce = ingredientFactory.CreateSauce();
      Cheese = ingredientFactory.CreateCheese();

    }
  }
}