using System;
using System.Collections.Generic;

namespace Learn.DesignPatterns.Content._02_Observer
{
  class MeasurementTracker : IObservable<Measurement>
  {
    public MeasurementTracker()
    {
      observers = new List<IObserver<Measurement>>();
    }

    private List<IObserver<Measurement>> observers;

    public IDisposable Subscribe(IObserver<Measurement> observer)
    {
      if (!observers.Contains(observer)) observers.Add(observer);

      return new Unsubscriber(observers, observer);
    }

    private class Unsubscriber : IDisposable
    {
      private List<IObserver<Measurement>> _observers;
      private IObserver<Measurement> _observer;

      public Unsubscriber(List<IObserver<Measurement>> observers, IObserver<Measurement> observer)
      {
        _observers = observers;
        _observer = observer;
      }
      
      public void Dispose()
      {
        if (_observer != null && _observers.Contains(_observer)) _observers.Remove(_observer);
      }
    }

    public void TrackMeasurement(Measurement measurement)
    {
      foreach (var observer in observers)
      {
        observer.OnNext(measurement);
      }
    }

    public void EndTransmission()
    {
      foreach (var observer in observers.ToArray())
        if (observers.Contains(observer)) observer.OnCompleted();

      observers.Clear();
    }
  }
}
