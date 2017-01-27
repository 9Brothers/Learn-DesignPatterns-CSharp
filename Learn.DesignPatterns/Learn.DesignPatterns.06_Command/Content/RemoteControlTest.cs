namespace Learn.DesignPatterns._06_Command.Content
{
  public abstract class RemoteControlTest
  {
    private RemoteControlTest()
    {
      
    }

    public static void Run()
    {
      var remote = new SimpleRemoteControl();

      var light = new Light();
      var lightOn = new LightOnCommand(light);

      remote.Command = lightOn;
      remote.ButtonWesPressed();

      var garageDoor = new GarageDoor();
      var garageDoorOpen = new GarageDoorOpenCommand(garageDoor);

      remote.Command = garageDoorOpen;
      remote.ButtonWesPressed();
    }
  }
}
