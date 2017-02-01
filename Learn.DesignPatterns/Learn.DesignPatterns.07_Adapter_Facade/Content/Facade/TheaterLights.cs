using System;

namespace Learn.DesignPatterns._07_Adapter_Facade.Content.Facade
{
  public class TheaterLights
  {
    internal void Dim(int v)
    {
      Console.WriteLine("TheaterLights Dim = " + v);
    }

    internal void On()
    {
      Console.WriteLine("TheaterLights On");
    }
  }
}
