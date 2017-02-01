using System.Collections;

namespace Learn.DesignPatterns._07_Adapter_Facade
{
  public class People : IEnumerable
  {
    private Person[] people;

    public People(Person[] people)
    {
      this.people = new Person[people.Length];

      for (int i = 0; i < people.Length; i++)
      {
        this.people[i] = people[i];
      }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) GetEnumerator();
    }

    public IEnumerator GetEnumerator()
    {
      return new PeopleEnum(people);
    }
  }
}
