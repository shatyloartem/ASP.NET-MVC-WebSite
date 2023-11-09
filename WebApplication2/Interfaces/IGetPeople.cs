namespace WebApplication2.Interfaces;

public interface IGetPeople
{
    public IEnumerable<Person> GetPeople(int startIndex = 0, int lastIndex = 50);

    public IEnumerable<PersonExtended> GetExtendedPeople(int startIndex = 0, int lastIndex = 50);
}