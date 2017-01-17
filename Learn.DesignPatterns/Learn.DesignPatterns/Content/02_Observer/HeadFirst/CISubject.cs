using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DesignPatterns.Content._02_Observer
{
  interface CISubject
  {
    void registerObserver(CIObserver observer);
    void removeObserver(CIObserver observer);
    void notifyObservers();
  }
}
