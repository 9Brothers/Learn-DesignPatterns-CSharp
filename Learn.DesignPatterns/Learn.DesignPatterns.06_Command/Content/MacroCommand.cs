namespace Learn.DesignPatterns._06_Command.Content
{
  public class MacroCommand : ICommand
  {
    ICommand[] commands;

    public MacroCommand(ICommand[] commands)
    {
      this.commands = commands;
    }

    public void Execute()
    {
      for (int i = 0; i < commands.Length; i++)
      {
        commands[i].Execute();
      }
    }

    public void Undo()
    {
      
    }
  }
}
