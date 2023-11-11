using WebApplication2.Interfaces;

namespace WebApplication2.Models
{
    public class PeopleDataModel : IGetPeople
    {
        private static readonly List<PersonExtended> SavedUsers = new List<PersonExtended>()
        {
            new PersonExtended(0, "Artem", "Shatylo", "shatyloartem@gmail.com", new DateTime(2023, 11, 9, 9, 54, 32), "The best programmer out there. Modest."),
            new PersonExtended(1, "Viktoria", "Korneva", "somemail@gmail.com", new DateTime(2023, 11, 9, 9, 54, 32), "test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test test "),
            new PersonExtended(2, "Test", "Test", "test@gmail.com", new DateTime(2023, 11, 9, 9, 54, 32), "test test")
        }; 
            
        
        public IEnumerable<Person> GetUsers(int startIndex = 0, int lastIndex = 50)
        {
            Console.WriteLine($"People count: {SavedUsers.Count}");
            return SavedUsers;
        }

        public IEnumerable<PersonExtended> GetExtendedUsers(int startIndex = 0, int lastIndex = 50)
        {
            return SavedUsers;
        }

        public int GetFreeId()
        {
            return SavedUsers.Last().Id + 1;
        }

        public void AddUser(PersonExtended user)
        {
            SavedUsers.Add(user);
        }
    }
}
