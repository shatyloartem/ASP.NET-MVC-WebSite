namespace WebApplication2.Interfaces;

public interface IGetPeople
{
    public IEnumerable<Person> GetUsers(int startIndex = 0, int lastIndex = 50);

    public IEnumerable<PersonExtended> GetExtendedUsers(int startIndex = 0, int lastIndex = 50);
}