namespace ICT_profile.Data;

public class ContactUpdateVM
{
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public Guid UserId { get; set; }
}
