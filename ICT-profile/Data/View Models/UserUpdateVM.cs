namespace ICT_profile.View_Models;

public class UserUpdateVM
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string JobTitle { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
}
