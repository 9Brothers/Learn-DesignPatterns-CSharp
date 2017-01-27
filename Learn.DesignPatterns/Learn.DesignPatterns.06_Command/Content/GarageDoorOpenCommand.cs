namespace Learn.DesignPatterns._06_Command.Content
{
  public class GarageDoorOpenCommand : ICommand
  {
    GarageDoor garageDoor;

    public GarageDoorOpenCommand(GarageDoor garageDoor)
    {
      this.garageDoor = garageDoor;
    }

    public void Execute()
    {
      garageDoor.Open();
    }

    public void Undo()
    {
      garageDoor.Close();
    }
  }
}
