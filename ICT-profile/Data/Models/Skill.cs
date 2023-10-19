namespace ICT_profile.Data;

public class Skill
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public User? User { get; set; }
    public Guid? UserId { get; set; }
}
