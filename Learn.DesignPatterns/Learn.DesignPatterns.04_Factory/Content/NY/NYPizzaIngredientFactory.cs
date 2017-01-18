using Learn.DesignPatterns.Content._04_Factory.Ingredients;
using System;
using System.Collections.Generic;

namespace Learn.DesignPatterns.Content._04_Factory.NY
{
  public class NYPizzaIngredientFactory : PizzaIngredientFactory
  {
    public Cheese CreateCheese()
    {
      return new ReggianoCheese();
    }

    public Clam CreateClam()
    {
      return new FreshClam();
    }

    public Dough CreateDough()
    {
      return new ThinCrustDough();
    }

    public Pepperoni CreatePepperoni()
    {
      return new SlicedPepperoni();
    }

    public Sauce CreateSauce()
    {
      return new MarinaraSauce();
    }

    public List<Veggies> CreateVeggies()
    {
      Console.WriteLine("Add NY Veggies");

      var veggies = new List<Veggies>();
      veggies.Add(new Garlic());
      veggies.Add(new Onion());
      veggies.Add(new Mushroom());
      veggies.Add(new RedPepper());

      return veggies;
    }
  }
}
