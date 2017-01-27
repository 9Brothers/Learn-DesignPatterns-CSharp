using System;

namespace Learn.DesignPatterns._06_Command.Content
{
  public abstract class RemoteLoader
  {
    public static void Run()
    {
      var remoteControl = new RemoteControlWithUndo();

      var livingRoomLight = new Light("Living Room");
      var kitchenLight = new Light("Kitchen");
      var stereo = new Stereo("Living Room", "Killswitch Engage");
      var ceilingFan = new CeilingFan("Bedroom");

      var livingRoomLightOn = new LightOnCommand(livingRoomLight);
      var livingRoomLightOff = new LightOffCommand(livingRoomLight);
      var kitchenLightOn = new LightOnCommand(kitchenLight);
      var kitchenLightOff = new LightOffCommand(kitchenLight);
      var ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);

      var stereoOnWithCD = new StereoOnWithCDCommand(stereo);
      var stereoOffWithCD = new StereoOffCommand(stereo);

      remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
      remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
      remoteControl.SetCommand(2, stereoOnWithCD, stereoOffWithCD);
      remoteControl.SetCommand(3, ceilingFanHigh, stereoOffWithCD);
      
      remoteControl.OnButtonWasPushed(0);
      remoteControl.OffButtonWasPushed(0);
      Console.WriteLine(remoteControl);
      remoteControl.UndoButtonWesPushed();
      remoteControl.OffButtonWasPushed(0);
      remoteControl.OnButtonWasPushed(0);
      Console.WriteLine(remoteControl);
      remoteControl.UndoButtonWesPushed();

      remoteControl.OnButtonWasPushed(1);
      remoteControl.OffButtonWasPushed(1);

      remoteControl.OnButtonWasPushed(2);
      remoteControl.OffButtonWasPushed(2);

      remoteControl.OnButtonWasPushed(3);
      Console.WriteLine(remoteControl);
      remoteControl.UndoButtonWesPushed();
    }
  }
}
