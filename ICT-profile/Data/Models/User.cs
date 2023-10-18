namespace ICT_profile.Data;

public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }= string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string About { get; set; } = string.Empty;
    //public Contact? Contact { get; set; }
}
