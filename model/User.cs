

public enum RoleTypes{
    User,
    Admin,
    Teacher,
    Manager

}

public class User{
    public int Id{set;get;}
    public string FullName{get;set;}
    public string Email{get;set;}
    public RoleTypes Role{get;set;}=RoleTypes.User;
    public string PasswordHash { get; set; }
    public DateTime CreatedAt{get;set;}

}