namespace BuberDinner.Domain.Entities;

public partial class User {
    public User(string firstName , string lastName, string password, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Password = password;
        Email = email;
    }

    public Guid Id { get; set;} = Guid.NewGuid();
    public string FirstName { get; set;} = null!;

    public string LastName { get; set;} = null!;

    public string Email{get; set;} = null!;

    public string Password{get; set;} = null!;

}