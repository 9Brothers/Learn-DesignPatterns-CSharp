using System;

namespace Learn.DesignPatterns._06_Command.Content
{
  public class LightOnCommand : ICommand
  {
    Light light;

    public LightOnCommand(Light light)
    {
      this.light = light;
    }

    public void Execute()
    {
      light.On();
    }

    public void Undo()
    {
      light.Off();
    }
  }
}
