using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DesignPatterns._07_Adapter_Facade.Content
{
  public abstract class App
  {
    public static void Run()
    {
      Person[] peoples = new Person[3]
      {
        new Person("Heber", "Teixeira"),
        new Person("Rubens", "Teixeira"),
        new Person("Renilda", "Rosa de Sousa")
      };

      People peopleList = new People(peoples);

      foreach (Person p in peopleList)
      {
        Console.WriteLine(p.firstName + " " + p.lastName);
      }
    }
  }
}
