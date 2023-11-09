using WebApplication2.Interfaces;

namespace WebApplication2.Models
{
    public class PeopleDataModel : IGetPeople
    {
        private readonly List<PersonExtended> _savedPeople = new List<PersonExtended>()
        {
            new PersonExtended(0, "Artem", "Shatylo", "shatyloartem@gmail.com", new DateTime(2023, 11, 9, 9, 54, 32), "The best programmer out there. Modest."),
            new PersonExtended(1, "Viktoria", "Korneva", "somemail@gmail.com", new DateTime(2023, 11, 9, 9, 54, 32), "test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test "),
            new PersonExtended(2, "Test", "Test", "test@gmail.com", new DateTime(2023, 11, 9, 9, 54, 32), "test test")
        }; 
            
        
        public IEnumerable<Person> GetPeople(int startIndex = 0, int lastIndex = 50)
        {
            return _savedPeople;
        }

        public IEnumerable<PersonExtended> GetExtendedPeople(int startIndex = 0, int lastIndex = 50)
        {
            return _savedPeople;
        }

        public int GetFreeId()
        {
            return _savedPeople.Last().Id + 1;
        }

        public void AddUser(PersonExtended user) => _savedPeople.Add(user);
    }
}
