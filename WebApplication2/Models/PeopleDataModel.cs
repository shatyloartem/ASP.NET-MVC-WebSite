using WebApplication2.Interfaces;

namespace WebApplication2.Models
{
    public class PeopleDataModel : IGetPeople
    {
        private readonly List<PersonExtended> _savedPeople = new List<PersonExtended>()
        {
            new PersonExtended(0, "Artem", "Shatylo", "shatyloartem@gmail.com", 4031192023, "The best programmer existed. Modest."),
            new PersonExtended(1, "Viktoria", "Korneva", "somemail@gmail.com", 4051192023, "test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test "),
            new PersonExtended(2, "Test", "Test", "test@gmail.com", 4051192023, "test test")
        }; 
            
        
        public IEnumerable<Person> GetPeople(int startIndex = 0, int lastIndex = 50)
        {
            return _savedPeople;
        }

        public IEnumerable<PersonExtended> GetExtendedPeople(int startIndex = 0, int lastIndex = 50)
        {
            return _savedPeople;
        }
    }
}
