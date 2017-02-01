using System;

namespace Learn.DesignPatterns._07_Adapter_Facade.Content.Facade
{
  public class DvdPlayer
  {
    internal void On()
    {
      Console.WriteLine("DvdPlayer On");
    }

    internal void Play(string movie)
    {
      Console.WriteLine("Movie: " + movie);
    }

    internal void Stop()
    {
      Console.WriteLine("DvdPlayer Stop");
    }

    internal void Eject()
    {
      Console.WriteLine("DvdPlayer Eject");
    }

    internal void Off()
    {
      Console.WriteLine("DvdPlayer Off");
    }
  }
}
