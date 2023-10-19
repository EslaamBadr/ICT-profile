namespace ICT_profile.Data;

public class Contact
{
    //public int Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public User? User { get; set; }
    public Guid? UserId { get; set; }
}
