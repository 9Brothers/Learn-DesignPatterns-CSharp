namespace Learn.DesignPatterns._06_Command.Content
{
  public class SimpleRemoteControl
  {
    ICommand slot;

    public SimpleRemoteControl()
    {

    }

    public ICommand Command
    {
      set
      {
        slot = value;
      }
    }

    public void ButtonWesPressed()
    {
      slot.Execute();
    }
  }
}
