using Learn.DesignPatterns._04_Factory.Content.Chicago;
using Learn.DesignPatterns.Content._04_Factory.NY;
using System;

namespace Learn.DesignPatterns.Content._04_Factory
{
  abstract class PizzaTestDrive
  {
    public static void Run()
    {
      PizzaStore nyStore = new NYStylePizzaStore();

      Pizza pizza = nyStore.OrderPizza("cheese");
      Console.WriteLine("Ethan ordered a " + pizza.Name + "\n\n");


      PizzaStore chicagoStore = new ChicagoStylePizzaStore();
      pizza = chicagoStore.OrderPizza("pepperoni");
      Console.WriteLine("Ethan ordered a " + pizza.Name);

      //PizzaStore depStore = new DependentPizzaStore("Chicago");

      //pizza = depStore.OrderPizza("cheese");
      //Console.WriteLine("Ethan ordered a " + pizza.Name);
    }
  }
}
