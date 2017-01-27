namespace Learn.DesignPatterns._06_Command.Content
{
  public class StereoOffCommand : ICommand
  {
    Stereo stereo;

    public StereoOffCommand(Stereo stereo)
    {
      this.stereo = stereo;
    }

    public void Execute()
    {
      stereo.Off();
    }

    public void Undo()
    {
      stereo.On();
      stereo.SetCD();
      stereo.SetVolume(11);
    }
  }
}
