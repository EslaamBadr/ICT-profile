namespace ICT_profile.Data;

public class Licenses_Certificates
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public User? User { get; set; }
    public Guid? UserId { get; set; }
}
