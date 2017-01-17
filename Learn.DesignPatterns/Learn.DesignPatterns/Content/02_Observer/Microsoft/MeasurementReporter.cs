using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DesignPatterns.Content._02_Observer
{
  class MeasurementReporter : IObserver<Measurement>
  {
    private IDisposable unsubscriber;
    private string instName;
    
    public MeasurementReporter(string name)
    {
      this.instName = name;
    }

    public string Name { get { return this.instName; } }

    public virtual void Subscribe(IObservable<Measurement> provider)
    {
      if (provider != null) unsubscriber = provider.Subscribe(this);
    }

    public void OnCompleted()
    {
      Console.WriteLine("The Measurement Tracker has completed transmitting data to {0}.", this.Name);
      Unsubscribe();
    }

    public void OnError(Exception error)
    {
      Console.WriteLine("{0}: The measurement cannot be determined.", this.Name);
    }

    public void OnNext(Measurement measurement)
    {
      Console.WriteLine("Current conditions: " + measurement.Temperature + "F degrees and " + measurement.Humidity + "% humidity");      
    }

    public virtual void Unsubscribe()
    {
      unsubscriber.Dispose();
    }
  }
}
