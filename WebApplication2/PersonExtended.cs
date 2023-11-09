namespace WebApplication2;

public class PersonExtended : Person
{
    public string Email;

    public string UserDescription;
    
    public uint RegistrationTime;
    
    public PersonExtended(int id, string name, string surname, string email, uint registrationTime, string userDescription) : base(id, name, surname)
    {
        Email = email;
        RegistrationTime = registrationTime;
        UserDescription = userDescription;
    }
}