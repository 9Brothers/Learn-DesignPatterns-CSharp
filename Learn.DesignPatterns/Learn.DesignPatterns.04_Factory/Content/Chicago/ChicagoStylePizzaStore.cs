using Learn.DesignPatterns.Content._04_Factory;
using Learn.DesignPatterns.Content._04_Factory.Chicago;

namespace Learn.DesignPatterns._04_Factory.Content.Chicago
{
  public class ChicagoStylePizzaStore : PizzaStore
  {
    public override Pizza CreatePizza(string type)
    {
      Pizza pizza = null;
      PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

      if (type.Equals("cheese")) pizza = new CheesePizza(ingredientFactory) { Name = "Chicago Style Cheese Pizza" };
      else if (type.Equals("veggie")) pizza = new VeggiePizza(ingredientFactory) { Name = "Chicago Style Veggie Pizza" };
      else if (type.Equals("clam")) pizza = new ClamPizza(ingredientFactory) { Name = "Chicago Style Clam Pizza" };
      else if (type.Equals("pepperoni")) pizza = new PepperoniPizza(ingredientFactory) { Name = "Chicago Style Pepperoni Pizza" };

      return pizza;
    }
  }
}
