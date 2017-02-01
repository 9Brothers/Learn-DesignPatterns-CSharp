using System;

namespace Learn.DesignPatterns._07_Adapter_Facade.Content.Facade
{
  public class Projector
  {
    internal void On()
    {
      Console.WriteLine("DvdPlayer On");
    }

    internal void WideScreenMode()
    {
      Console.WriteLine("DvdPlayer WideScreenMode");
    }

    internal void Off()
    {
      Console.WriteLine("DvdPlayer Off");
    }
  }
}
