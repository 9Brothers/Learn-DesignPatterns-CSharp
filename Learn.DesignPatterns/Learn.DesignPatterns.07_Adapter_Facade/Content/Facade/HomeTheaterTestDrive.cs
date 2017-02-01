namespace Learn.DesignPatterns._07_Adapter_Facade.Content.Facade
{
  public abstract class HomeTheaterTestDrive
  {
    public static void Run()
    {
      var homeTheater = new HomeTheaterFacade(new Amplifier(), new MyTuner(), new DvdPlayer(), new CdPlayer(), new Projector(), new TheaterLights(), new Screen(), new PopcornPopper());
      homeTheater.WatchMovie("Interestellar");
      homeTheater.EndMovie();
    }
  }
}
