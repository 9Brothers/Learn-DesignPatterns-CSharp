using System;
using System.Collections.Generic;

namespace Learn.DesignPatterns.Content._04_Factory.Chicago
{
  public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
  {
    public Cheese CreateCheese()
    {      
      return new ParmesaoCheese();
    }

    public Clam CreateClam()
    {      
      return new MolhadoClam();
    }

    public Dough CreateDough()
    {
      
      return new GreatCrustDough();
    }

    public Pepperoni CreatePepperoni()
    {
      return new DeliciousPepperoni();
    }

    public Sauce CreateSauce()
    {
      return new SayonaraSauce();
    }

    public List<Veggies> CreateVeggies()
    {
      Console.WriteLine("Add Chicago Veggies");

      var veggies = new List<Veggies>();
      veggies.Add(new GarlicJr());
      veggies.Add(new OnionTor());
      veggies.Add(new MushroomInfected());
      veggies.Add(new RedPepperChilliHot());

      return veggies;
    }
  }
}