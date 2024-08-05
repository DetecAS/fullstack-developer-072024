namespace BlazorAssessment.Models;

public class User
{
    public Guid Id  { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime LastLoginDate { get; set; }


    public User(string name, string email, DateTime lastLoginDate)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        LastLoginDate = lastLoginDate;
    }

    public User()
    {
        
    } 
}