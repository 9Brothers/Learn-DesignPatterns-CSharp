using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Learn.DesignPatterns._05_Singleton.Content
{
  public class ChocolateBoiler
  {
    private volatile static ChocolateBoiler uniqueInstance;

    private bool empty;
    private bool boiled;

    private ChocolateBoiler()
    {
      empty = true;
      boiled = false;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public static ChocolateBoiler GetInstance()
    {
      lock(uniqueInstance)
      {
        if (uniqueInstance == null) uniqueInstance = new ChocolateBoiler();

        return uniqueInstance;
      }
    }

    public void Fill()
    {
      if(IsEmpty())
      {
        empty = false;
        boiled = false;
      }
    }

    public void Drain()
    {
      if(!IsEmpty() && IsBoiled())
      {
        empty = true;
      }
    }

    public void Boil()
    {
      if (!IsEmpty() && !IsBoiled()) boiled = true;
    }

    public bool IsEmpty()
    {
      return empty;
    }

    public bool IsBoiled()
    {
      return boiled;
    }
  }
}
