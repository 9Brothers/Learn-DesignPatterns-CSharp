using System;

namespace Learn.DesignPatterns._07_Adapter_Facade.Content.Facade
{
  public class Screen
  {
    internal void Down()
    {
      Console.WriteLine("Screen Down");
    }

    internal void Up()
    {
      Console.WriteLine("Screen Up");
    }
  }
}
