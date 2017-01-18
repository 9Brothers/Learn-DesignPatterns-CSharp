using System;

namespace Learn.DesignPatterns.Content._02_Observer
{
  class CurrentConditionsDisplay : CIObserver, CIDisplayElement
  {
    private Measurement measurements;
    private CISubject weatherData;

    public CurrentConditionsDisplay(CISubject weatherData)
    {
      this.weatherData = weatherData;
      weatherData.registerObserver(this);
    }

    public void update(double temperature, double humidity, double pressure)
    {
      measurements.Temperature = temperature;
      measurements.Humidity = humidity;
      display();
    }

    public void display()
    {
      Console.WriteLine("Current conditions: " + measurements.Temperature + "F degrees and " + measurements.Humidity + "% humidity");
    }
  }
}
