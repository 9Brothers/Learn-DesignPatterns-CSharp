namespace Learn.DesignPatterns.Content._04_Factory.NY
{
  public class NYStylePizzaStore : PizzaStore
  {
    public override Pizza CreatePizza(string type)
    {
      Pizza pizza = null;
      PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

      if (type.Equals("cheese")) pizza = new CheesePizza(ingredientFactory) { Name = "New York Style Cheese Pizza" };
      else if (type.Equals("veggie")) pizza = new VeggiePizza(ingredientFactory) { Name = "New York Style Veggie Pizza" };
      else if (type.Equals("clam")) pizza = new ClamPizza(ingredientFactory) { Name = "New York Style Clam Pizza" };
      else if (type.Equals("pepperoni")) pizza = new PepperoniPizza(ingredientFactory) { Name = "New York Style Pepperoni Pizza" };

      return pizza;
    }
  }
}
