namespace WebApplication2;

public class User
{
    public readonly int Id;

    public readonly string Name;

    public readonly string Surname;
    
    public readonly string Email;

    public readonly string UserDescription;

    public readonly DateTime RegistrationDate;
    
    public User(int id, string name, string surname, string email, string userDescription, DateTime registrationTime)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Email = email;
        UserDescription = userDescription;
        RegistrationDate = registrationTime;
    }
}