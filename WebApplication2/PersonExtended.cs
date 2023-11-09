namespace WebApplication2;

public class PersonExtended : Person
{
    public string Email;

    public string UserDescription;
    
    public DateTime RegistrationDate;
    
    public PersonExtended(int id, string name, string surname, string email, DateTime registrationTime, string userDescription) : base(id, name, surname)
    {
        Email = email;
        RegistrationDate = registrationTime;
        UserDescription = userDescription;
    }
}