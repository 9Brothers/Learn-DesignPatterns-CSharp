using System;

namespace Learn.DesignPatterns._06_Command.Content
{
  public class Stereo
  {
    string place = null;
    string artista = null;

    public Stereo(string place, string artista)
    {
      this.place = " " + place;

      this.artista = " do artista " + artista;
    }

    public Stereo() : this("", "")
    {

    }

    public void On()
    {
      Console.WriteLine("\nStereo ligado" + place);
    }

    public void SetCD()
    {
      Console.WriteLine("Adicionado CD" + artista);
    }

    internal void SetVolume(int volume)
    {
      Console.WriteLine("Volume ajustado para " + volume);
    }

    internal void Off()
    {
      Console.WriteLine("Stereo desligado" + place);
    }
  }
}
