using System;
using System.Runtime.Serialization;

namespace Learn.DesignPatterns.Content._02_Observer
{
  [Serializable]
  internal class MeasurementUnknownException : Exception
  {
    public MeasurementUnknownException()
    {
    }

    public MeasurementUnknownException(string message) : base(message)
    {
    }

    public MeasurementUnknownException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected MeasurementUnknownException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
  }
}