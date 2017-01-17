namespace Learn.DesignPatterns.Content._02_Observer
{
  interface CISubject
  {
    void registerObserver(CIObserver observer);
    void removeObserver(CIObserver observer);
    void notifyObservers();
  }
}
