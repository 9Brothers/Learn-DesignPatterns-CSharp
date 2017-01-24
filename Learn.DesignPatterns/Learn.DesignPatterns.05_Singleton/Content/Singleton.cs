using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DesignPatterns._05_Singleton.Content
{
  public class Singleton
  {
    private static Singleton uniqueInstace;

    private Singleton()
    {

    }

    public static Singleton UniqueInstance
    {
      get
      {
        if (uniqueInstace == null) uniqueInstace = new Singleton();

        return uniqueInstace;
      }
    }
  }
}
