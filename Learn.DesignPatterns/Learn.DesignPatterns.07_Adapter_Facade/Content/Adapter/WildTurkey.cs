using System;

namespace Learn.DesignPatterns._07_Adapter_Facade.Content
{
  public class WildTurkey : Turkey
  {
    public void Fly()
    {
      Console.WriteLine("Gobble gobble");
    }

    public void Gobble()
    {
      Console.WriteLine("I'm flying a short distance");
    }
  }
}
