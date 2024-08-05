namespace BlazorAssessment.Models;

public class User
{


    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime LastLoginDate { get; set; }

    public User(string userName, string email, DateTime lastLoginDateTime)
    {
        Id = Guid.NewGuid();
        Name = userName;
        Email = email;
        LastLoginDate = lastLoginDateTime;
    }

    public User()
    {
        
        
    }
}