namespace Learn.DesignPatterns.Content._02_Observer
{
  abstract class WeatherStation
  {
    public static void Run()
    {
      // HEAD FIRST
      //var weatherData = new WeatherData();
      //var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

      //weatherData.setMeasurements(80, 65, 30.4);
      //weatherData.setMeasurements(82, 70, 29.2);
      //weatherData.setMeasurements(78, 90, 29.2);
      
      // MICROSOFT
      var provider = new MeasurementTracker();
      var reporter = new MeasurementReporter("Medidas");
      reporter.Subscribe(provider);

      provider.TrackMeasurement(new Measurement
      {
        Humidity = 80,
        Pressure = 65,
        Temperature = 30.4
      });

      provider.EndTransmission();

      provider.TrackMeasurement(new Measurement
      {
        Humidity = 82,
        Pressure = 70,
        Temperature = 29.2
      });

      reporter.Unsubscribe();
    }
  }
}
