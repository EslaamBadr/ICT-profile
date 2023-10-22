namespace ICT_profile.Data;

public class About
{
    public int Id { get; set; }
    public string AboutUser { get; set; }=string.Empty;

    public User? User { get; set; }
    public Guid? UserId { get; set; }
}
