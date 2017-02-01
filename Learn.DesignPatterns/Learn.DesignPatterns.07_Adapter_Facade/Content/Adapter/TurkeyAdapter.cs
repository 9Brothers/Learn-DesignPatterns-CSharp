namespace Learn.DesignPatterns._07_Adapter_Facade.Content
{
  public class TurkeyAdapter : Duck
  {
    Turkey turkey;

    public TurkeyAdapter(Turkey turkey)
    {
      this.turkey = turkey;
    }

    public void Fly()
    {
      for (int i = 0; i < 5; i++)
      {
        turkey.Fly();
      }
    }

    public void Quack()
    {
      turkey.Gobble();
    }
  }
}
