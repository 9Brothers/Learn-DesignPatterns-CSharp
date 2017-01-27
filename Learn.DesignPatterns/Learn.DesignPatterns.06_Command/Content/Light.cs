using System;

namespace Learn.DesignPatterns._06_Command.Content
{
  public class Light
  {
    string message;

    public Light(string message)
    {
      this.message = " " + message;
    }

    public Light() : this("")
    { }

    public void On()
    {
      Console.WriteLine("\nLigou a lâmpada" + message);
    }

    internal void Off()
    {
      Console.WriteLine("Desligou a lâmpada" + message);
    }
  }
}
