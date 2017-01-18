using System.Collections.Generic;

namespace Learn.DesignPatterns.Content._04_Factory
{
  public interface PizzaIngredientFactory
  {
    Dough CreateDough();
    Sauce CreateSauce();
    Cheese CreateCheese();
    List<Veggies> CreateVeggies();
    Pepperoni CreatePepperoni();
    Clam CreateClam();
  }
}
