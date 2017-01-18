using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
