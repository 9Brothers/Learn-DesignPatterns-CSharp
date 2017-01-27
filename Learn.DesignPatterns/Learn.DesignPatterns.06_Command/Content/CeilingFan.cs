namespace Learn.DesignPatterns._06_Command.Content
{
  public class CeilingFan
  {
    string location;
    private FanVelocities speed;

    public CeilingFan(string location)
    {
      this.location = location;
      speed = FanVelocities.OFF;
    }

    public void High()
    {
      speed = FanVelocities.HIGH;
    }

    public void Medium()
    {
      speed = FanVelocities.MEDIUM;
    }

    public void Low()
    {
      speed = FanVelocities.MEDIUM;
    }

    public void Off()
    {
      speed = FanVelocities.OFF;
    }

    public FanVelocities Speed
    {
      get
      {
        return speed;
      }
    }
  }
}
