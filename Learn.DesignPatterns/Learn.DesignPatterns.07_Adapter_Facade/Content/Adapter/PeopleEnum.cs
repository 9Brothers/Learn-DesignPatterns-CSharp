using System;
using System.Collections;

namespace Learn.DesignPatterns._07_Adapter_Facade
{
  class PeopleEnum : IEnumerator
  {
    public Person[] people;
    int position = -1;

    public PeopleEnum(Person[] people)
    {
      this.people = people;
    }

    object IEnumerator.Current
    {
      get
      {
        return Current;
      }
    }

    public object Current
    {
      get
      {
        try
        {
          return people[position];
        }
        catch (IndexOutOfRangeException)
        {
          throw new InvalidOperationException();
        }
      }
    }

    public bool MoveNext()
    {
      position++;
      return (position < people.Length);
    }

    public void Reset()
    {
      position = -1;
    }
  }
}
