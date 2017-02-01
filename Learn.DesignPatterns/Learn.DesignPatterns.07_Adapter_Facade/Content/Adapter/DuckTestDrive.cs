using System;

namespace Learn.DesignPatterns._07_Adapter_Facade.Content
{
  public abstract class DuckTestDrive
  {
    public static void Run()
    {
      WildTurkey turkey = new WildTurkey();
      Duck turkeyAdapter = new TurkeyAdapter(turkey);

      Console.WriteLine("The Turkey says...");
      turkey.Gobble();
      turkey.Fly();

      Console.WriteLine("\nThe TurkeyAdapter says...");
      TestDuck(turkeyAdapter);
    }

    private static void TestDuck(Duck duck)
    {
      duck.Quack();
      duck.Fly();
    }
  }
}
