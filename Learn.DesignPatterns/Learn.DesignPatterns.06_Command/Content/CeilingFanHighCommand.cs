using System;

namespace Learn.DesignPatterns._06_Command.Content
{
  public class CeilingFanHighCommand : ICommand
  {
    CeilingFan ceilingFan;
    FanVelocities prevSpeed;

    public CeilingFanHighCommand(CeilingFan ceilingFan)
    {
      this.ceilingFan = ceilingFan;
    }

    public void Execute()
    {
      prevSpeed = ceilingFan.Speed;
      ceilingFan.High();
    }

    public void Undo()
    {
      if (prevSpeed == FanVelocities.HIGH) ceilingFan.High();
      else if (prevSpeed == FanVelocities.MEDIUM) ceilingFan.Medium();
      else if (prevSpeed == FanVelocities.LOW) ceilingFan.Low();
      else if (prevSpeed == FanVelocities.OFF) ceilingFan.Off();
    }
  }
}
