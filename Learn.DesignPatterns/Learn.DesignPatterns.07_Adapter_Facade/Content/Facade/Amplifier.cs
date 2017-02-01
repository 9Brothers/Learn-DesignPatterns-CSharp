using System;

namespace Learn.DesignPatterns._07_Adapter_Facade.Content.Facade
{
  public class Amplifier
  {
    DvdPlayer dvd;

    internal void On()
    {
      Console.WriteLine("Amplifier On");
    }

    internal void SetDvd(DvdPlayer dvd)
    {
      this.dvd = dvd;
    }

    internal void SetSurroundSound()
    {
      Console.WriteLine("Amplifier Set Surround");
    }

    internal void SetVolume(int v)
    {
      Console.WriteLine("Amplifier SetVolume" + v);
    }

    internal void Off()
    {
      Console.WriteLine("Amplifier Off");
    }
  }
}
