using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DesignPatterns._07_Adapter_Facade
{
  class EnumerationIterator : IEnumerator
  {
    Enum enumeration;

    public EnumerationIterator(Enum enumeration)
    {
      this.enumeration = enumeration;
    }

    public object Current
    {
      get
      {
        throw new NotImplementedException();
      }
    }

    public bool MoveNext()
    {
      throw new NotImplementedException();
    }

    public void Reset()
    {
      throw new NotImplementedException();
    }
  }
}
