using Learn.DesignPatterns.Content._04_Factory.NY;

namespace Learn.DesignPatterns.Content._04_Factory
{
  class NYPizzaStore : PizzaStore
  {
    public override Pizza CreatePizza(string type)
    {
      PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

      if (type.Equals("cheese")) return new NYStyleCheesePizza(ingredientFactory);
      else if (type.Equals("pepperoni")) return new NYStylePepperoniPizza(ingredientFactory);
      else if (type.Equals("clam")) return new NYStyleClamPizza(ingredientFactory);
      else if (type.Equals("veggie")) return new NYStyleVeggiePizza(ingredientFactory);
      else return null;
    }
  }
}
