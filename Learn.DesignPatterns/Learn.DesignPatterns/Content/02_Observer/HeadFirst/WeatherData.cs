using System.Collections.Generic;

namespace Learn.DesignPatterns.Content._02_Observer
{
  class WeatherData : CISubject
  {
    private List<CIObserver> observers;
    private double temperature;
    private double humidity;
    private double pressure;

    public WeatherData()
    {
      observers = new List<CIObserver>();
    }

    public void notifyObservers()
    {
      foreach (var observer in observers)
      {
        observer.update(temperature, humidity, pressure);
      }
    }

    public void registerObserver(CIObserver observer)
    {
      observers.Add(observer);
    }

    public void removeObserver(CIObserver observer)
    {
      observers.Remove(observer);
    }

    public void measumentsChanged()
    {
      notifyObservers();
    }

    public void setMeasurements(double temperature, double humidity, double pressure)
    {
      this.temperature = temperature;
      this.humidity = humidity;
      this.pressure = pressure;
      measumentsChanged();
    }
  }
}
