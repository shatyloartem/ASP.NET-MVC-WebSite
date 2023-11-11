namespace WebApplication2.Models
{
    public class PeopleDataModel
    {
        private static readonly List<User> SavedUsers = new List<User>()
        {
            new User(0, "Name1", "Surname1", "test@gmail.com", "Test description", DateTime.Now),
            new User(1, "Name2", "Surname2", "test@gmail.com", "Test description", DateTime.Now),
            new User(2, "Name3", "Surname3", "test@gmail.com", "Test description", DateTime.Now)
        };
        
        public IEnumerable<User> GetUsers()
        {
            return SavedUsers;
        }

        public User GetUserById(int id)
        {
            foreach (var user in SavedUsers)
            {
                if (user.Id == id)
                    return user;
            }

            return null;
        }
        
        public int GetFreeId()
        {
            if(SavedUsers.Any())
                return SavedUsers.Last().Id + 1;

            return 0;
        }

        public void AddUser(User user)
        {
            SavedUsers.Add(user);
        }

        public void RemoveUserById(int id)
        {
            var users = SavedUsers.ToList();

            foreach (var user in users)
            {
                if (user.Id == id)
                    SavedUsers.Remove(user);
            }
        }
    }
}
